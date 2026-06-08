using System;

namespace ITSupport.Models
{
    public class RequestViewModel
    {
        public int Id { get; set; }
        public string ProblemDesc { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Status { get; set; }
        public string PriorityName { get; set; }
        public string CategoryName { get; set; }
        public int? PriorityId { get; set; }       
    }
}