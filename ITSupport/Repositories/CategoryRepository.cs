using System.Collections.Generic;
using System.Linq;
using Dapper;
using ITSupport.Data;
using ITSupport.Models;

namespace ITSupport.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        public Category GetById(int id)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = "SELECT * FROM Categories WHERE Id = @Id AND IsActive = 1";
                return connection.QueryFirstOrDefault<Category>(sql, new { Id = id });
            }
        }

        public IEnumerable<Category> GetAll()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = "SELECT * FROM Categories WHERE IsActive = 1 ORDER BY Name";
                return connection.Query<Category>(sql);
            }
        }

        public void Add(Category entity)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = @"INSERT INTO Categories (Name, Description, IsActive) 
                               VALUES (@Name, @Description, @IsActive);
                               SELECT CAST(SCOPE_IDENTITY() as int)";
                entity.Id = connection.QuerySingle<int>(sql, entity);
            }
        }

        public void Update(Category entity)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = @"UPDATE Categories 
                               SET Name = @Name, Description = @Description, IsActive = @IsActive 
                               WHERE Id = @Id";
                connection.Execute(sql, entity);
            }
        }

        public void Delete(int id)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                // Soft delete
                string sql = "UPDATE Categories SET IsActive = 0 WHERE Id = @Id";
                connection.Execute(sql, new { Id = id });
            }
        }
    }
}