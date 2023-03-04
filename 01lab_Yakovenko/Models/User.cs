using _01lab_Yakovenko.ZodiacSigns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01lab_Yakovenko.Models
{
    internal class User
    {
        private int _age;
        private DateTime _dateOfBirth;
        private ZodiacSign _westernSign;
        private ChineseSign _chineseSign;

        public int Age {
            get { return _age; }
            set { _age = value; } 
        }
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
        public ZodiacSign WesternSign
        {
            get { return _westernSign; }
            set { _westernSign = value; }
        }
        public ChineseSign ChineseSign
        {
            get { return _chineseSign; }
            set { _chineseSign = value; }
        }
    }

}
