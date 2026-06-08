using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSupport.Models
{
    public class Request
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ProblemDesc { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Status { get; set; }
        public int? PriorityId { get; set; }
        public int? CategoryId { get; set; }

        public virtual User User { get; set; }
        public virtual Priority Priority { get; set; }
        public virtual Category Category { get; set; }
        public string PriorityName { get; set; }
        public string CategoryName { get; set; }
        public string UserName { get; set; }
        public int? Rating { get; set; }
    }
}
