using Core;
using Dapper;
using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MMM_API
{

    [RoutePrefix("api/MMM")]
    public class LoginAPIController : BaseAPI
    {
        //private static string STR_CONTROLLER_NAME = "LoginAPI";

        [Route("UserLogin")]
        [HttpGet]
        [HttpPost]
        public IHttpActionResult UserLogin(string user, string pass)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            Login login = new Login();
            login.UserName = user;
            login.Password = pass;
            Employee _employee = new Employee();
            try
            {

                //  HttpResponseMessage response = new HttpResponseMessage();
                var _parameters = new DynamicParameters();
                _parameters.Add(StoredProcedure.PARAM_MODE, StoredProcedure.MODE_TWO);
                _parameters.Add(AppConstants.CONST_USER_NAME, login.UserName);
                _parameters.Add(AppConstants.CONST_PASSWORD, BaseEncrypt(login.Password.Trim()));

                _employee = new DataMapper().RetrieveRecords(_parameters, StoredProcedure.SP_RETRIEVE_EMPLOYEES).Select(x => new Employee
                {
                    EmployeeID = x.EmployeeID,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Email = x.Email,
                    MenuVisibleFlag = x.MenuVisibilityFlag == null ? false : x.MenuVisibilityFlag,
                    CompanyName = x.CompanyName,
                    RoleName = x.Name,
                    CompanyID = x.CompanyID,
                    PropertyName = x.PropertyName == null ? AppConstants.EMPTY_STRING : x.PropertyName,
                    PropertyID = x.PropertyID == null ? AppConstants.NUMERIC_NO_VALUE : x.PropertyID,
                    PropertyLogID = x.PropertyLogID == null ? AppConstants.NUMERIC_NO_VALUE : x.PropertyLogID,
                    PropertyLogName = x.PropertyLogName == null ? AppConstants.EMPTY_STRING : x.PropertyLogName,
                    PropertyshceduleStartTime = x.shceduleStartTime == null ? AppConstants.DEFAULT_START_TIME : x.shceduleStartTime,
                    PropertyshceduleEndTime = x.shceduleEndTime == null ? AppConstants.DEFAULT_END_TIME : x.shceduleEndTime,
                    PropertyCount = x.PropertyCount,
                    POPrefix = x.POPrefix == null ? AppConstants.EMPTY_STRING : x.POPrefix,
                    RoleID = x.AdminLevel,
                    UserName = x.UserName,
                    ErrorMessage = x.ErrorMessage,
                    ProfileImage = string.IsNullOrEmpty(x.ProfileImage) ? x.Profile_Image : Encrypt(x.CompanyID) + x.ProfileImage,
                    DefaultGridSize = x.DefaultGridSize == null ? AppConstants.STRING_TWENTY_FIVE : x.DefaultGridSize,
                }).SingleOrDefault();

                return Ok(_employee);
            }
            catch (Exception ex)
            {
                return LogException(STR_CONTROLLER_NAME, "UserLogin", "Login Model: " + JsonString(login), ex);
            }
        }

        [Route("getdata")]
        public IHttpActionResult GetLogin()
        {
            List<string> lst = new List<string>();
            lst.Add("11111");
            lst.Add("22222");
            lst.Add("55555");
            return Ok(lst);
        }
        //[HttpPost]
        //public HttpResponseMessage UserForgotPassword(Login login)
        //{
        //    Employee _employee = new Employee();
        //    try
        //    {
        //        HttpResponseMessage response = new HttpResponseMessage();
        //        var _parameters = new DynamicParameters();
        //        _parameters.Add(AppConstants.CONST_USER_NAME, login.UserName);
        //        _parameters.Add(AppConstants.CONST_RESET_PASSWORD_GUID, login.ResetPasswordGUID);
        //        _parameters.Add(StoredProcedure.PARAM_MODE, StoredProcedure.MODE_FIVE);
        //        _employee = new DataMapper().RetrieveRecords(_parameters, StoredProcedure.SP_RETRIEVE_EMPLOYEES).Select(x => new Employee
        //        {
        //            EmployeeID = x.EmployeeID,
        //            FirstName = x.FirstName,
        //            LastName = x.LastName,
        //            Email = x.Email,
        //            UserName = x.UserName,
        //            ErrorMessage = x.ErrorMessage,
        //            CompanyID = x.CompanyID
        //        }).SingleOrDefault();

        //        return Request.CreateResponse(HttpStatusCode.OK, _employee);
        //    }
        //    catch(Exception ex)
        //    {
        //        return LogException(STR_CONTROLLER_NAME, "UserForgotPassword", "Login Model: " + JsonString(login), ex);
        //    }
        //}
    }
}
