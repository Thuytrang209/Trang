using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Trang.Class_Student
{
    class Student
    {
        /**
         * Name student
         * full name student
         * student public
         * Name string
         **/
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

        private string _password;
        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                HashAlgorithm hassword = new MD5CryptoServiceProvider();
                byte[] hassbyte = hassword.ComputeHash(Encoding.UTF8.GetBytes(value));
                this._password = Convert.ToBase64String(hassbyte);
            }
        }

    }
}
