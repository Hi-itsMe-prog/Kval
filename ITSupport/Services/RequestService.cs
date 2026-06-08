using System;
using System.Collections.Generic;
using System.Linq;
using ITSupport.Models;
using ITSupport.Repositories;

namespace ITSupport.Services
{
    public class RequestService
    {
        private readonly RequestRepository _requestRepository;
        private readonly SolutionRepository _solutionRepository;
        private readonly CommentRepository _commentRepository;
        private readonly PriorityRepository _priorityRepository;
        private readonly CategoryRepository _categoryRepository;

        public RequestService()
        {
            _requestRepository = new RequestRepository();
            _solutionRepository = new SolutionRepository();
            _commentRepository = new CommentRepository();
            _priorityRepository = new PriorityRepository();
            _categoryRepository = new CategoryRepository();
        }

        public IEnumerable<RequestViewModel> GetRequestsForUser(User currentUser)
        {
            return currentUser.Role == "ITSpecialist"
                ? _requestRepository.GetAllRequestsWithDetails()
                : _requestRepository.GetRequestsByUser(currentUser.Id);
        }

        public Request GetRequestById(int id) => _requestRepository.GetById(id);

        public void CreateRequest(int userId, string problemDesc, int priorityId, int categoryId)
        {
            _requestRepository.Add(new Request
            {
                UserId = userId,
                ProblemDesc = problemDesc,
                Status = "New",
                PriorityId = priorityId,
                CategoryId = categoryId,
                CreatedAt = DateTime.Now
            });
        }

        public void UpdateRequestStatus(int requestId, string newStatus) =>
            _requestRepository.UpdateStatus(requestId, newStatus);

        public Solution GetSolutionByRequestId(int requestId) =>
            _solutionRepository.GetByRequestId(requestId);

        public void AddSolution(int requestId, int itSpecialistId, string solutionText)
        {
            _solutionRepository.Add(new Solution
            {
                RequestId = requestId,
                ItSpecialistId = itSpecialistId,
                SolutionText = solutionText,
                CompletedAt = DateTime.Now
            });
            _requestRepository.UpdateStatus(requestId, "Resolved");
        }

        public bool HasSolution(int requestId) => _solutionRepository.HasSolution(requestId);

        public IEnumerable<Comment> GetCommentsByRequestId(int requestId, User currentUser)
        {
            bool includeInternal = currentUser.Role == "ITSpecialist";
            return _commentRepository.GetCommentsByRequestId(requestId, includeInternal);
        }

        public void AddComment(int requestId, int authorId, string commentText)
        {
            _commentRepository.Add(new Comment
            {
                RequestId = requestId,
                AuthorId = authorId,
                CommentText = commentText,
                Timestamp = DateTime.Now,
                IsInternal = false
            });
        }

        public void AddInternalComment(int requestId, int authorId, string commentText)
        {
            _commentRepository.Add(new Comment
            {
                RequestId = requestId,
                AuthorId = authorId,
                CommentText = commentText,
                Timestamp = DateTime.Now,
                IsInternal = true
            });
        }

        public IEnumerable<Priority> GetAllPriorities() => _priorityRepository.GetAll();

        public IEnumerable<Category> GetAllCategories() => _categoryRepository.GetAll();

        public int GetTotalRequestsCount() => _requestRepository.GetAll()?.Count() ?? 0;

        public int GetNewRequestsCount() => _requestRepository.GetRequestsByStatus("New")?.Count() ?? 0;

        public int GetRequestsByStatusCount(string status) =>
            _requestRepository.GetRequestsByStatus(status)?.Count() ?? 0;

        public void RateRequest(int requestId, int userId, int rating)
        {
            var request = _requestRepository.GetById(requestId);
            if (request == null || request.UserId != userId)
                throw new InvalidOperationException("Нельзя оценить эту заявку.");

            if (request.Status != "Resolved" && request.Status != "Closed")
                throw new InvalidOperationException("Оценить можно только решённую заявку.");

            if (rating < 1 || rating > 5)
                throw new ArgumentOutOfRangeException(nameof(rating), "Оценка от 1 до 5.");

            _requestRepository.UpdateRating(requestId, rating);
        }

        public void CloseRequestByEmployee(int requestId, int userId)
        {
            var request = _requestRepository.GetById(requestId);
            if (request == null || request.UserId != userId)
                throw new InvalidOperationException("Нельзя закрыть эту заявку.");

            if (request.Status != "Resolved")
                throw new InvalidOperationException("Закрыть можно только решённую заявку.");

            _requestRepository.UpdateStatus(requestId, "Closed");
        }
    }
}
