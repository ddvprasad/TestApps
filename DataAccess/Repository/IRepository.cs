using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IRepository
    {
        //Inserting Records
        int InsertRecord(DynamicParameters parameter, string sql);

        //InsertMultipleRecord Records
        int InsertMultipleRecord(DynamicParameters parameter, string sql);

        //Delete Records
        int DeleteRecord(DynamicParameters parameter, string sql);

        //Updating Records
        int UpdateRecord(DynamicParameters parameter, string sql);

        //Get All Records
        IEnumerable<dynamic> GetAllRecords(DynamicParameters parameter, string sql);

        //Get Single Record
        dynamic GetRecord(DynamicParameters parameters, string sql);
    }
}
