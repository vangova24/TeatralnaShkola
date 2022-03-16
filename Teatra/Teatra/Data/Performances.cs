using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teatra.Data
{
    public class Performances
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Script { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public string PictureURL { get; set; }
        public float TicketPrice { get; set; }
        public DateTime Date_of_register { get; set; }
    }
}
