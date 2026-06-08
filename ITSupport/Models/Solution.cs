using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSupport.Models
{
   public class Solution
    {

        public int Id { get; set; }
        public int RequestId { get; set; }
        public int ItSpecialistId { get; set; }
        public string SolutionText { get; set; }
        public DateTime CompletedAt { get; set; }

        public virtual Request Request { get; set; }
        public virtual User ItSpecialist { get; set; }
    }
}
