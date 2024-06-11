using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.Model
{
    public class ArtPeriod : NamedEntity
    {
        public virtual ICollection<Artwork> Artworks { get; set; }
    }
}
