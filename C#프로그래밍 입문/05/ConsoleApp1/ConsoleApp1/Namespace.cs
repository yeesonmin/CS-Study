using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape

{
    public class Namespace
    {
        public int h = 1;
        public int w = 2;
        public override string ToString()
        {
            return string.Format("W = {0}, H = {1}", w, h);
        }
    }
}
