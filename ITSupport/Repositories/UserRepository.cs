using System.Collections.Generic;
using System.Linq;
using Dapper;
using ITSupport.Data;
using ITSupport.Models;
using ITSupport.Repositories;

namespace ITSupport.Repositories
{
    public class UserRepository : IRepository<User>
    {
        public User GetById(int id)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = "SELECT * FROM Users WHERE Id = @Id AND IsActive = 1";
                return connection.QueryFirstOrDefault<User>(sql, new { Id = id });
            }
        }

        public IEnumerable<User> GetAll()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = "SELECT * FROM Users WHERE IsActive = 1";
                return connection.Query<User>(sql);
            }
        }

        public void Add(User entity)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = @"INSERT INTO Users (Login, PasswordHash, Role, FullName, Email, Phone, IsActive) 
                               VALUES (@Login, @PasswordHash, @Role, @FullName, @Email, @Phone, @IsActive);
                               SELECT CAST(SCOPE_IDENTITY() as int)";

                entity.Id = connection.QuerySingle<int>(sql, entity);
            }
        }

        public void Update(User entity)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = @"UPDATE Users 
                               SET Login = @Login, 
                                   FullName = @FullName, 
                                   Email = @Email, 
                                   Phone = @Phone,
                                   IsActive = @IsActive,
                                   LastLoginAt = @LastLoginAt
                               WHERE Id = @Id";
                connection.Execute(sql, entity);
            }
        }

        public void Delete(int id)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = "UPDATE Users SET IsActive = 0 WHERE Id = @Id";
                connection.Execute(sql, new { Id = id });
            }
        }

        public User GetByLogin(string login)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = "SELECT * FROM Users WHERE Login = @Login AND IsActive = 1";
                return connection.QueryFirstOrDefault<User>(sql, new { Login = login });
            }
        }

        public void UpdateLastLogin(int userId)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = "UPDATE Users SET LastLoginAt = GETDATE() WHERE Id = @UserId";
                connection.Execute(sql, new { UserId = userId });
            }
        }

        public IEnumerable<User> GetITSpecialists()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = "SELECT * FROM Users WHERE Role = 'ITSpecialist' AND IsActive = 1";
                return connection.Query<User>(sql);
            }
        }
    }
}