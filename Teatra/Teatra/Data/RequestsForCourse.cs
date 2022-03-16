using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teatra.Data
{
    public class RequestsForCourse
    {
        [Key]
        public int Id { get; set; }

        public int CourseId { get; set; }
        public Courses Course { get; set; }

        public int UserId { get; set; }
        public Users User { get; set; }

        public string AditionalInfo { get; set; }
        public DateTime Date_of_request { get; set; }
    }
}
