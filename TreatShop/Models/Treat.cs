using System.Collections.Generic;

namespace TreatShop.Models
{
    public class Treat
    {
        public Treat()
        {
            this.Flavors = new HashSet<TreatFlavor>();
        }

        public int TreatId { get; set; }
        public string TreatName { get; set; }
        // public virtual ApplicationUser User { get; set; }

        public ICollection<TreatFlavor> Flavors { get;}
    }
}
