using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSysteem.Models
{
    public class Applicatie
    {
        public int Id { get; set; }
        [ForeignKey("Medewerker")]
        public int BeheerderId { get; set; }
        public Medewerker Beheerder { get; set; }

        public ICollection<Ticket> Tickets { get; set; }

    }
}
