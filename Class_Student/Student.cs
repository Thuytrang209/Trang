using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trang.Class_Student
{
    class Student
    {
        private string _name;
        public string Name
        {
            get
            {
                return "sinh viên" + this._name;
            }
        set 
            {
                this._name = value;
            }
        }
    }
}
