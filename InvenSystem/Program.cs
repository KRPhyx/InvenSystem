using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace InvenSystem
{
    class Program
    {
        static void Main(string[] args)
        {


            Inven NewInven = new Inven(5, 3);

            Item OldSword = new Item("낡은 검", 50);

            Item IronSword = new Item("철 검", 100);

            NewInven.Itemadd(OldSword);
            NewInven.Itemadd(IronSword);
            NewInven.Itemadd(new Item("포션", 30), 6);

            while (true)
            {
                Console.Clear();
                NewInven.Render();
                ConsoleKeyInfo CheckKey = Console.ReadKey();

                switch (CheckKey.Key)
                {
                    case ConsoleKey.LeftArrow:
                        NewInven.SelectMoveLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        NewInven.SelectMoveRight();
                        break;
                    case ConsoleKey.UpArrow:
                        NewInven.SelectMoveUp();
                        break;
                    case ConsoleKey.DownArrow:
                        NewInven.SelectMoveDown();
                        break;
                    default: return;
                }
            }
        }
    }

}
