using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Interface
{
    interface ILoadRes
    {
        object LoadRes(string path);
        object AsyLoadRes(string path);
    }
}
