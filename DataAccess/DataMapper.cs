using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DataAccess
{
    public class DataMapper : BaseObject
    {
        public IEnumerable<dynamic> RetrieveRecords(DynamicParameters parameters, string strSPName)
        {
            try
            {
                return _Repository.GetAllRecords(parameters, strSPName);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public dynamic ExecuteRecords(DynamicParameters parameters, string strSPName)
        {
            try
            {
                return _Repository.InsertRecord(parameters, strSPName);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
