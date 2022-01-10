using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ES.Models
{
    public class HienThiSoLieuModel
    {
        public int MatTroi_HienTai { get; set; }
        public int Gio_HienTai { get; set; }
        public int SinhKhoi_HienTai { get; set; }
        public int Tong_HienTai { get; set; }
        public string ThoiGian { get; set; }
    }
}
