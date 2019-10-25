using System.Collections.Generic;

namespace Bakery.Models
{
    public class Treat
    {
        public Treat()
        {
            // this.Flavors = new HashSet<FlavorTreat>();
        }

        public int TreatId { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public int Price { get; set; }
        public string Rating { get; set; }
        public virtual ApplicationUser User { get; set; }

        // public ICollection<FlavorTreat> Cuisines { get; }
    }
}