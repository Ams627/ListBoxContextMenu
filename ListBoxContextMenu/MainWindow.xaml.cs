using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using MvvmFoundation.Wpf;

namespace ListBoxContextMenu
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Loaded += (sender, e) => MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
            ContCommand = new RelayCommand(() =>
            {
                System.Diagnostics.Debug.WriteLine("Context Menu pressed");
            });
        }

        public ObservableCollection<string> Items { get; set; } = new ObservableCollection<string>{"Fred", "Jim", "Sheila"};
        public RelayCommand ContCommand { get; set; }
    }
}
