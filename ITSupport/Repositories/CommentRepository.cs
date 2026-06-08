using System.Collections.Generic;
using System.Linq;
using Dapper;
using ITSupport.Data;
using ITSupport.Models;

namespace ITSupport.Repositories
{
    public class CommentRepository : IRepository<Comment>
    {
        public Comment GetById(int id)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = @"SELECT c.*, u.FullName as AuthorName
                               FROM Comments c
                               INNER JOIN Users u ON c.AuthorId = u.Id
                               WHERE c.Id = @Id";

                return connection.QueryFirstOrDefault<Comment>(sql, new { Id = id });
            }
        }

        public IEnumerable<Comment> GetAll()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = @"SELECT c.*, u.FullName as AuthorName
                               FROM Comments c
                               INNER JOIN Users u ON c.AuthorId = u.Id
                               ORDER BY c.Timestamp DESC";

                return connection.Query<Comment>(sql);
            }
        }

        public void Add(Comment entity)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = @"INSERT INTO Comments (RequestId, AuthorId, CommentText, IsInternal, AttachmentPath) 
                               VALUES (@RequestId, @AuthorId, @CommentText, @IsInternal, @AttachmentPath);
                               SELECT CAST(SCOPE_IDENTITY() as int)";

                entity.Id = connection.QuerySingle<int>(sql, entity);
            }
        }

        public void Update(Comment entity)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = @"UPDATE Comments 
                               SET CommentText = @CommentText, 
                                   IsInternal = @IsInternal,
                                   AttachmentPath = @AttachmentPath
                               WHERE Id = @Id";

                connection.Execute(sql, entity);
            }
        }

        public void Delete(int id)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = "DELETE FROM Comments WHERE Id = @Id";
                connection.Execute(sql, new { Id = id });
            }
        }

        public IEnumerable<Comment> GetCommentsByRequestId(int requestId, bool includeInternal = false)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = @"SELECT c.*, u.FullName as AuthorName, u.Role as AuthorRole
                               FROM Comments c
                               INNER JOIN Users u ON c.AuthorId = u.Id
                               WHERE c.RequestId = @RequestId";

                if (!includeInternal)
                {
                    sql += " AND c.IsInternal = 0";
                }

                sql += " ORDER BY c.Timestamp ASC";

                return connection.Query<Comment>(sql, new { RequestId = requestId });
            }
        }

        public int GetCommentsCount(int requestId)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = "SELECT COUNT(1) FROM Comments WHERE RequestId = @RequestId";
                return connection.ExecuteScalar<int>(sql, new { RequestId = requestId });
            }
        }
    }
}