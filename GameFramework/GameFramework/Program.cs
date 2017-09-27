using GameFramework.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            GameClient gameClient = new GameClient(
                new GameData(), 
                new GameHelper(), 
                new GameInput(),
                new GameResource(),
                new GameView()
                );

            gameClient.Init();
            gameClient.Start();
            while(gameClient.IsRun)
            {
                gameClient.Update();
                //string s = Console.ReadLine();
                //if(s == "q")
                //{
                //    gameClient.Exit();
                //}
            }
        }
    }
}
