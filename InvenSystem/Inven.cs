using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InvenSystem
{
    class Inven
    {
        Item[] ArrItem;

        int ItemX;
        int ItemY;

        public Inven(int _X, int _Y)
        {
            if(_X < 1)
            {
                _X = 1;
            }
            if (_Y < 1)
            {
                _Y = 1;
            }

            ArrItem = new Item[(_X * _Y)];

            ItemX = _X;
            ItemY = _Y;

        }

        public void Render()
        {
            for(int i = 0;  i < ArrItem.Length; i++) 
            {
                if(i % ItemX == 0 && i != 0)
                {
                    Console.WriteLine("");
                }
                if (ArrItem[i] == null)
                {
                    Console.Write("□");
                }
                else { Console.Write("■"); }
            }
        }
        
        public void Itemadd(Item _Item)
        {
            int index = 0;
            //배열의 맨 끝에 아이템 추가
            for (int i = 0; i < ArrItem.Length; i++)
            {
                if (ArrItem[i] == null)
                {
                    index = i;
                    break;
                }
            }
            ArrItem[index] = _Item;
        }

        public void Itemadd(Item _Item, int _Order)
        {
            if(null != ArrItem[_Order])
            {
                return;
            }
            ArrItem[_Order] = _Item;
        }
    }
}
