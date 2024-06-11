using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.Model
{
    public class ImageAttachment
    {
        [Key]
        public int ID { get; set; }

        public string FilePath { get; set; }
        public string FileName { get; set; }

        
        [ForeignKey(nameof(Artwork))]
        public int ArtworkID { get; set; }
        public virtual Artwork Artwork { get; set; }
    }
}
