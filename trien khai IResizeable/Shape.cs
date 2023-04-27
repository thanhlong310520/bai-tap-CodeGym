using System;
using System.Collections.Generic;
using System.Text;

namespace trien_khai_IResizeable
{
    abstract class Shape:IResizeable
    {
        public abstract void Resize(double percent);
        
    }
}
