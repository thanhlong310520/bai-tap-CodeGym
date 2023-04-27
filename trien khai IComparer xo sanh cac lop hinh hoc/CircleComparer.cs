using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace trien_khai_IComparer_xo_sanh_cac_lop_hinh_hoc
{
    class CircleComparer : IComparer<Circle>
    {
        public int Compare([AllowNull] Circle x, [AllowNull] Circle y)
        {
            if (x.Radius > y.Radius) return 1;
            else if (x.Radius < y.Radius) return -1;
            else return 0;
        }
    }
}
