using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDepartman.Models
{
    public class personel
    {
        [Key]
        public int perid { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string sehir { get; set; }

        public departmanlar depart { get; set; }
    }
}
