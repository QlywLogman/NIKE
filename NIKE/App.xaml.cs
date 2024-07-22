using NIKE.ViewModels;
using NIKE.Views;
using System.ComponentModel;
using System;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Navigation;

namespace NIKE
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Container MainContainer { get; set; } = new();
        public App()
        {
            AddOtherServices();
            AddViews();
            AddViewModels();
        }

        private void AddOtherServices()
        {

        }

        private void AddViewModels()
        {
            MainContainer.RegisterSingleton<MainWindowViewModel>();
        }

        private void AddViews()
        {
            MainContainer.RegisterSingleton<MainWindow>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var mainView = MainContainer.GetInstance<MainWindow>();
            mainView.DataContext = MainContainer.GetInstance<MainWindowViewModel>();
            mainView.Show();
            base.OnStartup(e);
        }
    }

}
