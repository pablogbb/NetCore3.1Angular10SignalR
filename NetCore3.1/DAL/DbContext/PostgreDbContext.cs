using Dapper;
using Exceptions;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DbContext
{
    public class PostgreDbContext : IDbContext
    {
        public readonly string _connectionString;

        public PostgreDbContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("PostgresqlDBConnection");
        }

        public void ejecutarQuery(string query)
        {
            throw new NotImplementedException();
        }

        public void ejecutarQuery(string query, object parametros)
        {
            throw new NotImplementedException();
        }

        public Task ejecutarQueryAsync(string query)
        {
            throw new NotImplementedException();
        }

        public Task ejecutarQueryAsync(string query, object parametros)
        {
            throw new NotImplementedException();
        }

        public List<T> getList<T>(string query)
        {
            throw new NotImplementedException();
        }

        public T getObject<T>(string query)
        {
            throw new NotImplementedException();
        }

        public T getObject<T>(string query, object parametros)
        {
            throw new NotImplementedException();
        }

        public List<T> get_list<T>(string query, object parametros)
        {
            throw new NotImplementedException();
        }
    }
}
