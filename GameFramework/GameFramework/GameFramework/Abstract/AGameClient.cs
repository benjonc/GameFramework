using GameFramework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Abstract
{
    abstract class AGameClient: AGameSystem
    {
        // 游戏客户端抽象类
        // 包括游戏视图
        // 游戏数据
        // 游戏输入
        // 游戏工具类
        // 其中每个类都是一个系统
        protected AGameView _gameView;
        protected AGameData _gameData;
        protected AGameInput _gameInput;
        protected AGameHelper _gameHelper;
        protected AGameResource _gameResource;
        
        public override void Init()
        {
            _gameView.Init();
            _gameData.Init();
            _gameInput.Init();
            _gameHelper.Init();
            _gameResource.Init();
        }

        public override void Start()
        {
            _gameView.Start();
            _gameData.Start();
            _gameInput.Start();
            _gameHelper.Start();
            _gameResource.Start();
        }

        public override void Update()
        {
            _gameView.Update();
            _gameData.Update();
            _gameInput.Update();
            _gameHelper.Update();
            _gameResource.Update();
        }

        public override void Exit()
        {
            _gameView.Exit();
            _gameData.Exit();
            _gameInput.Exit();
            _gameHelper.Exit();
            _gameResource.Exit();
        }
    }

    // 模拟汽车
    class Car
    {
        // 车轮
        // 底盘
        // 引擎
        // 方向盘
        // 车框
        // 刹车

    }
}
