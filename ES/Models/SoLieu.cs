using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ES.Models
{
    public class SoLieu
    {
        [Key]
        public int ID { get; set; }
        public int MT_HT { get; set; }
        public int MT_CSLN { get; set; }
        public int MT_TK { get; set; }
        public int MT_SLN { get; set; }
        public int G_HT { get; set; }
        public int G_CSLN { get; set; }
        public int G_TK { get; set; }
        public int G_SLN { get; set; }
        public int SK_HT { get; set; }
        public int SK_CSLN { get; set; }
        public int SK_TK { get; set; }
        public int SK_SLN { get; set; }
        public int T_HT { get; set; }
        public int T_CSLN { get; set; }
        public int T_TK { get; set; }
        public int T_SLN { get; set; }
        public DateTime ThoiGian { get; set; }
    }
}
