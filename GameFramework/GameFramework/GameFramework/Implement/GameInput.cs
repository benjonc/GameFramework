using GameFramework.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Implement
{
    class GameInput : AGameInput
    {
        public override void Init()
        {
            base.Init();
            Console.WriteLine(this.ToString() + "----->" + "Init");
        }

        public override void Start()
        {
            base.Start();
            Console.WriteLine(this.ToString() + "----->" + "Start");
        }

        public override void Update()
        {
            base.Update();
            Console.WriteLine(this.ToString() + "----->" + "Update");
        }

        public override void Exit()
        {
            base.Exit();
            Console.WriteLine(this.ToString() + "----->" + "Exit");
        }
    }
}
