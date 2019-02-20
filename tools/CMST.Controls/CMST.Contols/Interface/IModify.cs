using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMST.Controls
{
    interface IModify
    {
        bool IsModified { get; }
        void Reset();
    }

}
