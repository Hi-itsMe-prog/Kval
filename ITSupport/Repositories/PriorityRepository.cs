using System.Collections.Generic;
using System.Linq;
using Dapper;
using ITSupport.Data;
using ITSupport.Models;
using ITSupport.Repositories;

namespace ITSupport.Repositories
{
    public class PriorityRepository : IRepository<Priority>
    {
        public Priority GetById(int id)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = "SELECT * FROM Priorities WHERE Id = @Id";
                return connection.QueryFirstOrDefault<Priority>(sql, new { Id = id });
            }
        }

        public IEnumerable<Priority> GetAll()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = "SELECT * FROM Priorities ORDER BY SortOrder";
                return connection.Query<Priority>(sql);
            }
        }

        public void Add(Priority entity)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = @"INSERT INTO Priorities (Name, Level, ColorCode, SortOrder) 
                               VALUES (@Name, @Level, @ColorCode, @SortOrder);
                               SELECT CAST(SCOPE_IDENTITY() as int)";
                entity.Id = connection.QuerySingle<int>(sql, entity);
            }
        }

        public void Update(Priority entity)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = @"UPDATE Priorities 
                               SET Name = @Name, Level = @Level, ColorCode = @ColorCode, SortOrder = @SortOrder 
                               WHERE Id = @Id";
                connection.Execute(sql, entity);
            }
        }

        public void Delete(int id)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = "DELETE FROM Priorities WHERE Id = @Id";
                connection.Execute(sql, new { Id = id });
            }
        }
    }
}