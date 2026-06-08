using System.Collections.Generic;
using System.Linq;
using Dapper;
using ITSupport.Data;
using ITSupport.Models;
using ITSupport.Repositories;

namespace ITSupport.Repositories
{
    public class SolutionRepository : IRepository<Solution>
    {
        public Solution GetById(int id)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = @"SELECT s.*, u.FullName as ITSpecialistName
                               FROM Solutions s
                               INNER JOIN Users u ON s.ItSpecialistId = u.Id
                               WHERE s.Id = @Id";

                return connection.QueryFirstOrDefault<Solution>(sql, new { Id = id });
            }
        }

        public IEnumerable<Solution> GetAll()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = @"SELECT s.*, u.FullName as ITSpecialistName
                               FROM Solutions s
                               INNER JOIN Users u ON s.ItSpecialistId = u.Id
                               ORDER BY s.CompletedAt DESC";

                return connection.Query<Solution>(sql);
            }
        }

        public void Add(Solution entity)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = @"INSERT INTO Solutions (RequestId, ItSpecialistId, SolutionText, CompletedAt) 
                       VALUES (@RequestId, @ItSpecialistId, @SolutionText, @CompletedAt);
                       SELECT CAST(SCOPE_IDENTITY() as int)";

                entity.Id = connection.QuerySingle<int>(sql, entity);
            }
        }

        public void Update(Solution entity)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = @"UPDATE Solutions 
                               SET SolutionText = @SolutionText, 
                                   TimeSpentMinutes = @TimeSpentMinutes,
                                   IsApproved = @IsApproved
                               WHERE Id = @Id";

                connection.Execute(sql, entity);
            }
        }

        public void Delete(int id)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = "DELETE FROM Solutions WHERE Id = @Id";
                connection.Execute(sql, new { Id = id });
            }
        }

        public Solution GetByRequestId(int requestId)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = @"SELECT s.*, u.FullName as ITSpecialistName
                               FROM Solutions s
                               INNER JOIN Users u ON s.ItSpecialistId = u.Id
                               WHERE s.RequestId = @RequestId";

                return connection.QueryFirstOrDefault<Solution>(sql, new { RequestId = requestId });
            }
        }

        public bool HasSolution(int requestId)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = "SELECT COUNT(1) FROM Solutions WHERE RequestId = @RequestId";
                return connection.ExecuteScalar<int>(sql, new { RequestId = requestId }) > 0;
            }
        }
    }
}