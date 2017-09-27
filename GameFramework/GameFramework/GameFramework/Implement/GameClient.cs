using GameFramework.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Implement
{
    class GameClient : AGameClient
    {
        public bool IsRun;
        public GameClient(
            AGameData gameData, 
            AGameHelper gameHelper, 
            AGameInput gameInput,
            AGameResource gameResource,
            AGameView gameView
            )
        {
            this._gameData = gameData;
            this._gameHelper = gameHelper;
            this._gameInput = gameInput;
            this._gameResource = gameResource;
            this._gameView = gameView;           
        }

        public override void Init()
        {
            base.Init();
            Console.WriteLine(this.ToString() + "----->" + "Init");
        }

        public override void Start()
        {
            base.Start();
            Console.WriteLine(this.ToString() + "----->" + "Start");
            IsRun = true;
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
            IsRun = false;
        }

    }
}
