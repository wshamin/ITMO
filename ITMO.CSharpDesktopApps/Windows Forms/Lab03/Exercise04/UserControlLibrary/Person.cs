using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControlLibrary
{
    public class Person
    {
        private string name;
        public string FullName
        {
            get { return name; }
            set { name = value; }
        }
    }
}
