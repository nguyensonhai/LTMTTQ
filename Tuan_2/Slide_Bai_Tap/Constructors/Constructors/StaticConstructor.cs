using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class StaticConstructor
    {
        private int mMaKH;
        private string mTenKH;
        public StaticConstructor()
        {
            mMaKH = 0; mTenKH = "ABC";
        }
        static StaticConstructor()
        {
            // Các câu lệnh…
        }

    }
}
