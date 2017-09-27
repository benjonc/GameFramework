using GameFramework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Abstract
{
    abstract class AGameResource : AGameSystem, ILoadRes
    {
        // 所有游戏的资源管理
            // 包括游戏的图形资源和代码资源
        public virtual object LoadRes(string path)
        {
            return null;
        }

        public virtual object AsyLoadRes(string path)
        {
            return null;
        } 
    }
}
