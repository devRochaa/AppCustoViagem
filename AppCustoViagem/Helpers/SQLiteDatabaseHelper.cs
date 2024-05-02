using AppCustoViagem.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCustoViagem.Helpers
{
    public class SQLiteDatabaseHelper
    {
        readonly SQLiteAsyncConnection _conn;

        public SQLiteDatabaseHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<pedagio>().Wait();
        }

        public Task<int> Insert(pedagio p)
        {
            return _conn.InsertAsync(p);

        }

        //public Task<List<pedagio>> Update(pedagio p)
        //{
        //    string sql = "Update pedagio set local=?, valor=? WHERE id=?";

        //    return _conn.QueryAsync<pedagio>(sql);
        //}

        public Task<int> Delete(int id)
        {
            return _conn.Table<pedagio>().DeleteAsync();
        }

        public Task<List<pedagio>> GetAll()
        {
            return _conn.Table<pedagio>().ToListAsync();
        }

        //public Task<List<pedagio>> Search(string q)
        //{
        //    string sql = "SELECT * FROM pedagio WHERE descricao LIKE '%" + q + "%';";
        //    return _conn.QueryAsync<pedagio>(sql);
        //}
    }
}
