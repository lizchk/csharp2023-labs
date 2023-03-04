using _01lab_Yakovenko.ViewModels;
using System.Windows.Controls;

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
