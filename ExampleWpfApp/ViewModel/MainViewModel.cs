using DevExpress.Mvvm;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace ExampleWpfApp.ViewModel
{
    class MainViewModel: ViewModelBase
    {
        private Page Welcome;
        private Page Main;
        private Page Test;
        private Page Exit;
        private Page _currentPage;
        public Page CurrentPage
        {
            get { return _currentPage; }
            set
            {
                _currentPage = value;
                RaisePropertyChanged(() => CurrentPage);
            }
        }

     

        private double _frameOpacity;
        public double FrameOpacity { get; set; }
        public MainViewModel()
        {
            Welcome = new View.Welcome();
            Main = new View.Main();
            Test = new View.Test();
            Exit = new View.Exit();
            FrameOpacity = 1;
            CurrentPage = Welcome;
        }
        public ICommand MenuMainClick
        {
            get
            {
                return new RelayCommand(() => SlowOpacity(Main));
            }
        }
        public ICommand MenuTestClick
        {
            get
            {
                return new RelayCommand(() => SlowOpacity(Test));
            }
        }
        public ICommand MenuExitClick
        {
            get
            {
                return new RelayCommand(() => SlowOpacity(Exit));
            }
        }

        private async void SlowOpacity(Page page)
        {
            await Task.Factory.StartNew(() =>
            {
                for (double i = 1.0; i > 0.0; i -= 0.1)
                {
                    FrameOpacity = i;
                    Thread.Sleep(50);
                }
                CurrentPage = page;
                for (double i = 0.0; i < 1.1; i += 0.1)
                {
                    FrameOpacity = i;
                    Thread.Sleep(50);
                }
            }
            );
        }
    }
}
