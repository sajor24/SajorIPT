using System.Windows;
using SajorIPT101Solution.SajorWPF.ViewModels;

namespace SajorIPT101Solution.SajorWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow(MainViewModel vm)
        {
            InitializeComponent();
            this.DataContext = vm;
        }
    }
}