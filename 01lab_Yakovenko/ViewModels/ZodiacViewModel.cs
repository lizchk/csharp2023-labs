using _01lab_Yakovenko.Models;
using _01lab_Yakovenko.ZodiacSigns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _01lab_Yakovenko.ViewModels
{
    internal class ZodiacViewModel : INotifyPropertyChanged
    {
        private User user = new User();
        private RelayCommand<object> _signCommand;
        public int Age
        {
            get { return user.Age; }
            set
            {
                user.Age = value;
                NotifyPropertyChanged();
            }
        }
        public DateTime DateOfBirth
        {
            get
            { return user.DateOfBirth; }
            set
            {
                user.DateOfBirth = value;
                AgeCommand();
                NotifyPropertyChanged();
            }
        }
        public ZodiacSign WesternSign
        {
            get { return user.WesternSign; }
            set
            {
                user.WesternSign = value;
                NotifyPropertyChanged();
            }
        }
        public ChineseSign ChineseSign
        {
            get { return user.ChineseSign; }
            set
            {
                user.ChineseSign = value;
                NotifyPropertyChanged();
            }
        }

        public RelayCommand<object> ShowSignsCommand
        {
            get { return _signCommand ??= new RelayCommand<object>(_ => SignCommand()); }
        }
        private void SignCommand()
        {
            WesternSign = CalcWestSign();
            ChineseSign = CalcChinSign();
        }

        private ChineseSign CalcChinSign()
        {
            return (ChineseSign)(DateOfBirth.Year % 12);
        }
        private ZodiacSign CalcWestSign()
        {

            int month = DateOfBirth.Month;
            int day = DateOfBirth.Day;

            switch (month)
            {
                case 1:
                    return (day <= 19) ? ZodiacSign.Capricorn : ZodiacSign.Aquarius;
                case 2:
                    return (day <= 18) ? ZodiacSign.Aquarius : ZodiacSign.Pisces;
                case 3:
                    return (day <= 20) ? ZodiacSign.Pisces : ZodiacSign.Aries;
                case 4:
                    return (day <= 19) ? ZodiacSign.Aries : ZodiacSign.Taurus;
                case 5:
                    return (day <= 20) ? ZodiacSign.Taurus : ZodiacSign.Gemini;
                case 6:
                    return (day <= 20) ? ZodiacSign.Gemini : ZodiacSign.Cancer;
                case 7:
                    return (day <= 22) ? ZodiacSign.Cancer : ZodiacSign.Leo;
                case 8:
                    return (day <= 22) ? ZodiacSign.Leo : ZodiacSign.Virgo;
                case 9:
                    return (day <= 22) ? ZodiacSign.Virgo : ZodiacSign.Libra;
                case 10:
                    return (day <= 22) ? ZodiacSign.Libra : ZodiacSign.Scorpio;
                case 11:
                    return (day <= 21) ? ZodiacSign.Scorpio : ZodiacSign.Sagittarius;
                default:
                    return (day <= 21) ? ZodiacSign.Sagittarius : ZodiacSign.Capricorn;

            }

        }

        private void AgeCommand()
        {
            Age = CalcAge();
        }

        private int CalcAge()
        {
            int age = DateTime.Now.Year - DateOfBirth.Year;
            if (DateTime.Now.Month < DateOfBirth.Month || (DateTime.Now.Month == DateOfBirth.Month && DateTime.Now.Day < DateOfBirth.Day))
            {
                age--;
            }
            if (age < 0 || age > 135)
            {
                MessageBox.Show("Date of birth entered incorrectly! Try again.");
            }
            if (DateTime.Now.Day == DateOfBirth.Day && DateTime.Now.Month == DateOfBirth.Month)
            {
                MessageBox.Show("Happy birthday)💖");
            }
            return age;
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
