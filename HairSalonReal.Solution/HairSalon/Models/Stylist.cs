using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Stylist
    {
        public Stylist()
        {
            this.Clients = new HashSet<Client>(); 
        }

        public string Name { get; set; }
        public string Specialty { get; set; }
        public int StylistId { get; set; }
        public virtual ICollection<Client> Clients { get; set; } 
        
    }
}