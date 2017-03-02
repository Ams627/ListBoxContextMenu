using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ListBoxContextMenu
{
    class BindingProxy : Freezable
    {
        protected override Freezable CreateInstanceCore()
        {
            return new BindingProxy();
        }



        public ListBox LBData
        {
            get { return (ListBox)GetValue(LBDataProperty); }
            set { SetValue(LBDataProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LBData.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LBDataProperty =
            DependencyProperty.Register("LBData", typeof(ListBox), typeof(BindingProxy), new PropertyMetadata(null));


        public object Data
        {
            get { return (object)GetValue(DataProperty); }
            set { SetValue(DataProperty, value); }
        }

        public static readonly DependencyProperty DataProperty =
            DependencyProperty.Register("Data", typeof(object), typeof(BindingProxy), new PropertyMetadata(null));
    }
}
