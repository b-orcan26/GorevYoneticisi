using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GorevYoneticisi.Models
{
    public class Plan
    {
        [Key]
        public String id { get; set; }
        public String aciklama { get; set; }
        public String baslik { get; set; }
        public String baslangicTarihi { get; set; }
        public String bitisTarihi { get; set; }
    }
}
