using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.Model
{
    public class Artwork : NamedEntity
    {
        public int YearCompleted { get; set; }

        [ForeignKey(nameof(Period))]
        public int PeriodID { get; set; }
        public virtual ArtPeriod Period { get; set; }


        [ForeignKey(nameof(Artist))]
        public int ArtistID { get; set; }
        public virtual Artist Artist { get; set; }


        public virtual ICollection<Attachment>? Images { get; set; }
        public virtual ICollection<Exhibition>? Exhibitions { get; set; }

    }
}
