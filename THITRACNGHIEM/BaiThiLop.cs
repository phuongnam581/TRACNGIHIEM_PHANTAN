using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THITRACNGHIEM
{
    class BaiThiLop
    {
        private int cauHoi;
        private int maDangKy;
        public static ArrayList baiThiLop = new ArrayList();
        public BaiThiLop(int cauHoi,int maDangKy)
        {
            this.cauHoi = cauHoi;
            this.maDangKy = maDangKy;
        }
        public int getCauHoi()
        {
            return cauHoi;
        }
        public int getMaDangKy()
        {
            return maDangKy;
        }
    }
}
