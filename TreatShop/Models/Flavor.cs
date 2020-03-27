using System.Collections.Generic;

namespace LibraryCatalog.Models
{
  public class Flavor
    {
        public Flavor()
        {
            this.Titles = new HashSet<Book>();
        }

        public int FlavorId { get; set; }
        public string FlavorName { get; set; }
        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<TreatFlavor> Treats { get; set; }
    }
}
