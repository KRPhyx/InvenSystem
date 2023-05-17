using System;
using System.Collections.Generic;
using System.Linq;
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
            NewInven.Itemadd(new Item("포션",30),6);

            while (true)
            {
                Console.Clear();
                NewInven.Render();
                Console.ReadKey();
            }
        }
    }

}
