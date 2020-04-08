using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSysteem.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public Applicatie Applicatie { get; set; }
        [ForeignKey("Applicatie")]
        public int ApplicatieId { get; set; }
        public Klant Klant { get; set; }
        [ForeignKey("Klant")]
        public int KlantId { get; set; }

        public string Onderwerp { get; set; }

        public string Omschrijving { get; set; }

        public Status Status { get; set; }
        [ForeignKey("Status")]
        public int StatusId { get; set; }

    }
}
