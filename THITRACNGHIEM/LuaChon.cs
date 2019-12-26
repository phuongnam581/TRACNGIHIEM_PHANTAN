using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THITRACNGHIEM
{
    class LuaChon
    {
        public int maLuaChon;
        public int cauHoi;
        public String moTa;
        public String thuTu;
        public static ArrayList danhSachLuaChon = new ArrayList();
        public LuaChon(int maLuaChon, int cauHoi, String moTa,String thuTu)
        {
            this.maLuaChon = maLuaChon;
            this.cauHoi = cauHoi;
            this.moTa = moTa;
            this.thuTu = thuTu;
        }
        public int getCauHoi()
        {
            return cauHoi;
        }
        public int getMaLuaChon()
        {
            return maLuaChon;
        }
        public String getMoTa()
        {
            return moTa;
        }
        public String getThuTu()
        {
            return thuTu;
        }
    }
}
