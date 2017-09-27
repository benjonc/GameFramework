using GameFramework.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.GameFramework
{
    class GameClient : AGameClient
    {
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

        }

    }
}
