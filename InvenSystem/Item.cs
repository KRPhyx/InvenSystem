using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvenSystem
{
    class Item
    {
        string mName;
        int MGold;

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }


        public int Gold
        {
            get { return MGold; }
            set { MGold = value; }
        }

        public Item(String _Name, int _Gold)
        {
            Name = _Name;
            Gold = _Gold;
        }
    }

}
