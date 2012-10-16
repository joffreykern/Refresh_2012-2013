using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3_Basics_CSharp
{
    class Properties
    {
        private int _number;
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        void UseNumber()
        {
            this.Number = 1;
            Console.WriteLine(this.Number);
        }

        public string MyString { get; set; }

        void UseString()
        {
            this.MyString = "a string";
            Console.WriteLine(this.MyString);
        }

    }
}
