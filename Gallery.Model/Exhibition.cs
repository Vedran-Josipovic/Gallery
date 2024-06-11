using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.Model
{
    public class Exhibition : NamedEntity
    {
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        

        [ForeignKey(nameof(Gallery))]
        public int GalleryID { get; set; }
        public virtual Gallery Gallery { get; set; }

        public virtual ICollection<Artwork>? Artworks { get; set; }
        public virtual ICollection<Artist>? Artists { get; set; }


    }
}
