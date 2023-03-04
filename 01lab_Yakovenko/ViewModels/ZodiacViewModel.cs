using _01lab_Yakovenko.Models;
using _01lab_Yakovenko.ZodiacSigns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01lab_Yakovenko.ViewModels
{
    internal class ZodiacViewModel
    {
        private User user = new User();
        private RelayCommand<object> _signCommand;
        public int Age 
        {
            get {return user.Age ;}
            set {user.Age = value ;}
        }
        public DateTime DateOfBirth
        {
            get { return user.DateOfBirth; }
            set { user.DateOfBirth = value; }
        }
        public ZodiacSign WesternSign
        { 
            get { return user.WesternSign; }
            set { user.WesternSign = value; }
        }
        public ChineseSign ChineseSign
        {
            get { return user.ChineseSign; }
            set { user.ChineseSign = value; }
        }

        public RelayCommand<object> RelayCommand 
        {
            get { return _signCommand ??= new RelayCommand<object>(_=>SignCommand);}
        }
        private void SignCommand()
        {
            WesternSign = CalcWestSign(DateOfBirth);
            ChineseSign = CalcChinSign(DateOfBirth);
        }

        private ChineseSign CalcChinSign(DateTime dateOfBirth)
        {

        }
        private ZodiacSign CalcWestSign(DateTime dateOfBirth)
        {

        }
    }
}
