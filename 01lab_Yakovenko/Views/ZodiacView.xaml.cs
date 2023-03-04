using _01lab_Yakovenko.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _01lab_Yakovenko.Views
{
    
    public partial class ZodiacView : UserControl
    {
        private ZodiacViewModel _viewModel;
        public ZodiacView()
        {

            InitializeComponent();
            DataContext = _viewModel = new ZodiacViewModel();
        }
    }
}
