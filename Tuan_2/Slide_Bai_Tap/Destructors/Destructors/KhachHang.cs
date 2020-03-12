using System;
using System.Collections.Generic;
using System.Text;

namespace Destructors
{
    class KhachHang
    {
        private int mKH;
        private string mTenKH;

        public KhachHang()
        {
            mKH = 0; mTenKH = "ABC";
        }
        ~KhachHang()
        {
            // Các câu lệnh…
        }

    }
}
