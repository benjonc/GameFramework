using GameFramework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Abstract
{
    abstract class AGameSystem : IInit, IStart, IUpdate, IExit
    {
        public virtual void Init()
        {

        }

        public virtual void Start()
        {
            
        }

        public virtual void Update()
        {

        }

        public virtual void Exit()
        {

        }
    }
}
