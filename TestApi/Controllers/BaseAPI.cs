using Core;
using Dapper;
using DataAccess;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Web.Http;

namespace MMM_API
{
    
    public class BaseAPI : ApiController
    {
        public static string STR_CONTROLLER_NAME = "APIBaseController";

        private static readonly string APP_SETT_DBCONNECTION_STRING = "DBConnection";

        private static string _dbConnectionString;

        public static string S_DBConnectionString
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(_dbConnectionString))
                    {
                        _dbConnectionString = Convert.ToString(ConfigurationManager.ConnectionStrings[APP_SETT_DBCONNECTION_STRING].ConnectionString);

                    }
                    return _dbConnectionString;
                }
                catch
                {
                    return AppConstants.EMPTY_STRING;
                }
            }
        }

        #region Encrypt & Decrypt

        protected string BaseEncrypt(string strInput)
        {
            string _encryptionKey = "ENManageMyMotels";
            byte[] _clearBytes = Encoding.Unicode.GetBytes(strInput);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(_encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(_clearBytes, 0, _clearBytes.Length);
                        cs.Close();
                    }
                    strInput = Convert.ToBase64String(ms.ToArray());
                }
            }
            return strInput;
        }

        protected string BaseDecrypt(string strInput)
        {
            string _encryptionKey = "ENManageMyMotels";
            strInput = strInput.Replace(" ", "+");
            byte[] _cipherBytes = Convert.FromBase64String(strInput);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(_encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(_cipherBytes, 0, _cipherBytes.Length);
                        cs.Close();
                    }
                    strInput = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return strInput;
        }

        //Encrypt method
        protected string Encrypt(int? iInput)
        {
            string _strResult = string.Empty;
            try
            {
                _strResult = Security.ManageMyMotelsSecurity.EncryptAndEncode(Convert.ToString(iInput));
            }
            catch (Exception ex)
            {
                LogException(STR_CONTROLLER_NAME, "Encrypt", "Input: " + iInput, ex);
            }
            return _strResult;
        }

        //Decrypt method
        protected int Decrypt(string strInput)
        {
            int _iResult = AppConstants.NUMERIC_NO_VALUE;
            try
            {
                _iResult = ConvertStringToInteger(Security.ManageMyMotelsSecurity.DecodeAndDecrypt(strInput));
            }
            catch (Exception ex)
            {
                LogException(STR_CONTROLLER_NAME, "Decrypt", "Input: " + strInput, ex);
            }
            return _iResult;
        }

        #endregion Encrypt & Decrypt


        #region Common Methods

        protected string JsonString(object value)
        {
            return JsonConvert.SerializeObject(value);
        }

        #endregion

        #region Exception Handling Methods

        protected IHttpActionResult LogException(string strController, string strAction, string strParameters, Exception exception)
        {
            IHttpActionResult response = null;
            try
            {
                LogExceptionMessage(strController, strAction, strParameters, exception);
            }
            catch (Exception ex)
            {
                LogMessage("Exception: " + ex.Message);
            }
            finally
            {
                response = Content(HttpStatusCode.InternalServerError, exception);
            }
            return response;
        }

        protected static void LogExceptionMessage(string strController, string strAction, string strParameters, Exception exception)
        {
            try
            {
                DataMapper _dataMapper = new DataMapper();
                var _parameters = new DynamicParameters();
                _parameters.Add(AppConstants.CONST_SCREEN_NAME, strController);
                _parameters.Add(AppConstants.CONST_FUNCTION_NAME, strAction);
                _parameters.Add(AppConstants.CONST_PARAMETER_VALUES, strParameters);
                _parameters.Add(AppConstants.CONST_ERROR_MESSAGE, exception.InnerException != null ? Convert.ToString(exception.InnerException) : exception.Message);
                _parameters.Add(StoredProcedure.PARAM_MODE, StoredProcedure.MODE_ONE);
                _dataMapper.ExecuteRecords(_parameters, StoredProcedure.SP_EXECUTE_ERROR_LOG);
            }
            catch (Exception ex)
            {
                BaseAPI obj = new BaseAPI();
                obj.LogMessage("Exception: Controller: " + strController + ", Action: " + strAction + ", Parameter: " + strParameters + ", Exception: " + ex.Message);
            }
        }

        #endregion

        protected void LogMessage(string strFunctionName)
        {
            string strTimeFile = AppDomain.CurrentDomain.BaseDirectory + "\\Log.txt";
            using (StreamWriter writer = new StreamWriter(System.IO.File.Open(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, strTimeFile), FileMode.Append)))
            {
                writer.WriteLine(strFunctionName + " " + System.DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss:fff"));
                writer.Close();
            }
        }

        //Convert string to intiger
        protected Int32 ConvertStringToInteger(string argValue)
        {
            try
            {
                return Convert.ToInt32(argValue);
            }
            catch (Exception)
            {
                return AppConstants.NUMERIC_NO_VALUE;
            }
        }
    }
}
