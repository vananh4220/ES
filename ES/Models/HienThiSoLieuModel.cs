using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ES.Models
{
    public class HienThiSoLieuModel
    {
        public int MT_HT { get; set; }
        public int G_HT { get; set; }
        public int SK_HT { get; set; }
        public int T_HT { get; set; }
        public string ThoiGian { get; set; }
    }
}
