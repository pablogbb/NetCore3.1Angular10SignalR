using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DbContext
{
    public interface IDbContext
    {
        List<T> getList<T>(string query);
        List<T> get_list<T>(string query, Object parametros);
        T getObject<T>(string query);
        T getObject<T>(string query, object parametros);
        Task ejecutarQueryAsync(string query);
        Task ejecutarQueryAsync(string query, Object parametros);
        void ejecutarQuery(string query);
        void ejecutarQuery(string query, Object parametros);
    }
}
