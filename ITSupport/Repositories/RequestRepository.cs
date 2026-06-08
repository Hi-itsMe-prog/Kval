using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using ITSupport.Data;
using ITSupport.Models;
using ITSupport.Repositories;

namespace ITSupport.Repositories
{
    public class RequestRepository : IRepository<Request>
    {
        public Request GetById(int id)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = @"SELECT r.*, 
                                      p.Name as PriorityName, 
                                      c.Name as CategoryName,
                                      u.FullName as UserName
                               FROM Requests r
                               LEFT JOIN Priorities p ON r.PriorityId = p.Id
                               LEFT JOIN Categories c ON r.CategoryId = c.Id
                               LEFT JOIN Users u ON r.UserId = u.Id
                               WHERE r.Id = @Id AND r.IsDeleted = 0";

                return connection.QueryFirstOrDefault<Request>(sql, new { Id = id });
            }
        }

        public IEnumerable<Request> GetAll()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = @"SELECT r.*, 
                                      p.Name as PriorityName, 
                                      c.Name as CategoryName,
                                      u.FullName as UserName
                               FROM Requests r
                               LEFT JOIN Priorities p ON r.PriorityId = p.Id
                               LEFT JOIN Categories c ON r.CategoryId = c.Id
                               LEFT JOIN Users u ON r.UserId = u.Id
                               WHERE r.IsDeleted = 0
                               ORDER BY r.CreatedAt DESC";

                return connection.Query<Request>(sql);
            }
        }

        public void Add(Request entity)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = @"INSERT INTO Requests (UserId, ProblemDesc, Status, PriorityId, CategoryId, CreatedAt) 
                       VALUES (@UserId, @ProblemDesc, @Status, @PriorityId, @CategoryId, @CreatedAt);
                       SELECT CAST(SCOPE_IDENTITY() as int)";

                entity.Id = connection.QuerySingle<int>(sql, entity);
            }
        }
        public void Update(Request entity)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = @"UPDATE Requests 
                               SET ProblemDesc = @ProblemDesc, 
                                   Status = @Status, 
                                   PriorityId = @PriorityId, 
                                   CategoryId = @CategoryId,
                                   ExpectedCompletionDate = @ExpectedCompletionDate,
                                   ActualCompletionDate = @ActualCompletionDate,
                                   Rating = @Rating
                               WHERE Id = @Id";

                connection.Execute(sql, entity);
            }
        }

        public void Delete(int id)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = "UPDATE Requests SET IsDeleted = 1 WHERE Id = @Id";
                connection.Execute(sql, new { Id = id });
            }
        }

        public IEnumerable<RequestViewModel> GetRequestsByUser(int userId)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = @"SELECT r.Id, 
                                      r.ProblemDesc, 
                                      r.CreatedAt, 
                                      r.Status,
                                      p.Name as PriorityName, 
                                      c.Name as CategoryName,
                                      u.FullName as UserName
                               FROM Requests r
                               INNER JOIN Priorities p ON r.PriorityId = p.Id
                               INNER JOIN Categories c ON r.CategoryId = c.Id
                               INNER JOIN Users u ON r.UserId = u.Id
                               WHERE r.UserId = @UserId AND r.IsDeleted = 0
                               ORDER BY r.CreatedAt DESC";

                return connection.Query<RequestViewModel>(sql, new { UserId = userId });
            }
        }

        public IEnumerable<RequestViewModel> GetAllRequestsWithDetails()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = @"SELECT r.Id, 
                                      r.ProblemDesc, 
                                      r.CreatedAt, 
                                      r.Status,
                                      p.Name as PriorityName, 
                                      c.Name as CategoryName,
                                      u.FullName as UserName
                               FROM Requests r
                               INNER JOIN Priorities p ON r.PriorityId = p.Id
                               INNER JOIN Categories c ON r.CategoryId = c.Id
                               INNER JOIN Users u ON r.UserId = u.Id
                               WHERE r.IsDeleted = 0
                               ORDER BY 
                                   CASE r.Status 
                                       WHEN 'New' THEN 1
                                       WHEN 'InProgress' THEN 2
                                       ELSE 3
                                   END,
                                   r.CreatedAt DESC";

                return connection.Query<RequestViewModel>(sql);
            }
        }

        public void UpdateRating(int requestId, int rating)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = "UPDATE Requests SET Rating = @Rating WHERE Id = @Id AND IsDeleted = 0";
                connection.Execute(sql, new { Rating = rating, Id = requestId });
            }
        }

        public void UpdateStatus(int requestId, string newStatus)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = @"UPDATE Requests 
                               SET Status = @Status,
                                   ActualCompletionDate = CASE 
                                       WHEN @Status IN ('Resolved', 'Closed') THEN GETDATE() 
                                       ELSE ActualCompletionDate 
                                   END
                               WHERE Id = @Id";

                connection.Execute(sql, new { Status = newStatus, Id = requestId });
            }
        }

        public IEnumerable<Request> GetRequestsByStatus(string status)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = @"SELECT * FROM Requests 
                               WHERE Status = @Status AND IsDeleted = 0 
                               ORDER BY CreatedAt DESC";

                return connection.Query<Request>(sql, new { Status = status });
            }
        }
    }
}