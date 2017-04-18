using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class BaseObject
    {
        public IRepository _Repository;

        public BaseObject()
            : this(new Repository())
        {
        }

        public BaseObject(IRepository Repository)
        {
            _Repository = Repository;
        }
    }
}
