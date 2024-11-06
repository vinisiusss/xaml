using DevExpress.Mvvm;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;

namespace ExampleWpfApp.ViewModel
{
    class TestViewModel : DevExpress.Mvvm.ViewModelBase
    {
        public ICommand TestClick
        {
            get
            {
                return new RelayCommand(() => MessageBox.Show("Test", "Message", MessageBoxButton.OK));
            }
        }
    }
}
