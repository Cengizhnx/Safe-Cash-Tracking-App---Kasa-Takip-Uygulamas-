using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yeniproje.Models
{
    public class EmpClass
    {
        public int id { get; set; } = 0;
        public string Kadi { get; set; } ="";
        public string Adsoyad { get; set; } = "";
        public string Tel { get; set; } = "";
        public string Adres { get; set; } = "";
        public string Acik { get; set; } = "";
        public string flag { get; set; } = "";
        public int ekle { get; set; } = 0;
        public int cikar { get; set; } = 0;
        public int Bakiye { get; set; } = 0;

    }
}
