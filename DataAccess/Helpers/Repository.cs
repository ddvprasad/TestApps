using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
namespace DataAccess
{
    public class Repository : IRepository
    {
        private IDbConnection _db = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);

        //Inserting Records
        public int InsertRecord(DynamicParameters parameters, string sql)
        {
            
            using (var transactionScope = new TransactionScope())
            {
                _db.Open();
                using (var transaction = _db.BeginTransaction())
                {
                    try
                    {
                        var Item = _db.Execute(sql, parameters, commandType: CommandType.StoredProcedure);
                        transaction.Commit();
                        transactionScope.Complete();
                        return Item;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                    finally
                    {
                        _db.Dispose();
                        transaction.Dispose();
                        transactionScope.Dispose();
                    }
                }
            }
            return 0;
        }

        public int InsertMultipleRecord(DynamicParameters parameters, string sql)
        {
            using (var transactionScope = new TransactionScope())
            {
                _db.Open();
                using (var transaction = _db.BeginTransaction())
                {
                    try
                    {
                        var Item = _db.QueryMultiple(sql, parameters, commandType: CommandType.StoredProcedure);
                        transaction.Commit();
                        transactionScope.Complete();
                        return 0;
                    }
                    catch (Exception ex)
                    {
                        var tt = ex;
                        transaction.Rollback();
                    }
                    finally
                    {
                        _db.Dispose();
                        transaction.Dispose();
                        transactionScope.Dispose();
                    }
                }
            }
            return 0;
        }

        //Updating Records
        public int UpdateRecord(DynamicParameters parameters, string sql)
        {
            using (var transactionScope = new TransactionScope())
            {
                _db.Open();
                using (var transaction = _db.BeginTransaction())
                {
                    try
                    {
                        var Item = _db.Execute(sql, parameters, commandType: CommandType.StoredProcedure);
                        transaction.Commit();
                        transactionScope.Complete();
                        return Item;
                    }
                    catch (Exception ex)
                    {
                        var tt = ex;
                        transaction.Rollback();
                    }
                    finally
                    {
                        _db.Dispose();
                        transaction.Dispose();
                        transactionScope.Dispose();
                    }
                }
            }
            return 0;
        }

        //Get All Records
        public IEnumerable<dynamic> GetAllRecords(DynamicParameters parameters, string sql)
        {
            return _db.Query<dynamic>(sql, parameters, commandType: CommandType.StoredProcedure);
        }

        //Get Single Record
        public dynamic GetRecord(DynamicParameters parameters, string sql)
        {
            return _db.Query<dynamic>(sql, parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        //Delete Records
        public int DeleteRecord(DynamicParameters parameters, string sql)
        {
            using (var transactionScope = new TransactionScope())
            {
                _db.Open();
                using (var transaction = _db.BeginTransaction())
                {
                    try
                    {
                        var Item = _db.Execute(sql, parameters, commandType: CommandType.StoredProcedure);
                        transaction.Commit();
                        transactionScope.Complete();
                        return Item;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                    finally
                    {
                        _db.Dispose();
                        transaction.Dispose();
                        transactionScope.Dispose();
                    }
                }
            }
            return 0;
        }

    }

}
