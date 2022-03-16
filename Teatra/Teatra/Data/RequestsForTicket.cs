using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teatra.Data
{
    public class RequestsForTicket
    {
        [Key]
        public int Id { get; set; }
        public int PerformanceId { get; set; }
        public Performances Performance { get; set; }

        public int UserId { get; set; }
        public Users User { get; set; }

        public int TicketCount { get; set; }
        public DateTime Date_of_request { get; set; }
    }
}
