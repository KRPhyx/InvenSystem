using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InvenSystem
{
    class Inven
    {
        int SelectindeX = 0;

        Item[] ArrItem;

        int ItemX;
        int ItemY;

        public Inven(int _X, int _Y)
        {
            if (_X < 1)
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

        public bool OverCheck(int _SelectIndex)
        {
            if (_SelectIndex < 0 || _SelectIndex > ItemX * ItemY - 1)
            {
                return true;
            }
            return false;
        }

        public void SelectMove()
        {

        }

        public void SelectMoveRight()
        {
            int CheckIndex = SelectindeX;
            CheckIndex += 1;

            if (OverCheck(CheckIndex) == true)
            {
                return;
            }

            SelectindeX += 1;
        }
        public void SelectMoveLeft()
        {
            int CheckIndex = SelectindeX;
            CheckIndex -= 1;

            if (OverCheck(CheckIndex) == true)
            {
                return;
            }

            SelectindeX -= 1;
        }
        public void SelectMoveUp()
        {
            int CheckIndex = SelectindeX;
            CheckIndex -= ItemX;

            if (OverCheck(CheckIndex) == true)
            {
                return;
            }

            SelectindeX -= ItemX;
        }
        public void SelectMoveDown()
        {
            int CheckIndex = SelectindeX;
            CheckIndex += ItemX;

            if (OverCheck(CheckIndex) == true)
            {
                return;
            }

            SelectindeX += ItemX;
        }

        public void Render()
        {
            for (int i = 0; i < ArrItem.Length; i++)
            {
                if (i % ItemX == 0 && i != 0)
                {
                    Console.WriteLine("");
                }

                if (i == SelectindeX)
                {
                    Console.Write("▣");
                }
                else if (ArrItem[i] == null)
                {
                    Console.Write("□");
                }
                else { Console.Write("■"); }
            }

            Console.WriteLine(" ");

            if (null != ArrItem[SelectindeX])
            {
                Console.WriteLine("현재 선택한 아이템");
                Console.WriteLine("이름 : " + ArrItem[SelectindeX].Name);
                Console.WriteLine("가격 : " + ArrItem[SelectindeX].Gold);
            }
            else
            {
                Console.WriteLine("현재 선택한 아이템");
                Console.WriteLine("비어있음");
            }
        }

        public void Itemadd(Item _Item)
        {
            int index = 0;
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
            if (null != ArrItem[_Order])
            {
                return;
            }
            ArrItem[_Order] = _Item;
        }
    }
}
