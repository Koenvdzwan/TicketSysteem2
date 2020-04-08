using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSysteem.Models
{
    public class Medewerker : Gebruiker
    {
        public ICollection<Applicatie>  Applicaties { get; set; }

    }
}
