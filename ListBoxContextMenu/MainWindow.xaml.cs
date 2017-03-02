    using System;
    using System.Collections.ObjectModel;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using MvvmFoundation.Wpf;

namespace ListBoxContextMenu
{
    public class Context
    {
        public string Name { get; set; }
        public Guid guid { get; set; }
        public bool Enabled { get; set; }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Loaded += (sender, e) => MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
            ContCommand = new RelayCommand<object>((object o) =>
            {
                System.Diagnostics.Debug.WriteLine("Context Menu pressed");
            });
        }

        public ObservableCollection<string> Items { get; set; } = new ObservableCollection<string>
        {
            "Fred",
            "Jim",
            "Sheila"
        };

        public RelayCommand<object> ContCommand { get; set; }


        public ObservableCollection<Context> ContextItems { get; set; } = new ObservableCollection<Context>
        {
            new Context() {Name = "Wonk", guid=Guid.NewGuid(), Enabled = true},
            new Context() {Name = "Wonk", guid=Guid.NewGuid(), Enabled = false},
            null,
            new Context() {Name = "Wonk", guid=Guid.NewGuid(), Enabled = true}
        };

    }
}
