using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProtoTypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            XboxGame xg = new Hello("Hello 4") { ProductKey = "00000-00000-00000-00000" }; //Original copy
            XboxGame gameCopy;
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(2000);
                gameCopy = xg.Clone();
                gameCopy.ProductKey = XboxGame.ProductKeyGeneration();
                Console.WriteLine("Game Title:{0} : Product Key:{1}", gameCopy.Title, gameCopy.ProductKey);
            }
        }

    }
}
