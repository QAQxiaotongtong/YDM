using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._20
{
   public  interface  IEnumerabale
    {
        object Current { get; }
        bool MoveNext();
        void Reset();
    }
}
