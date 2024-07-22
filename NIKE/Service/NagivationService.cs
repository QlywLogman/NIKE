using NIKE.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace NIKE.Service
{
    public class NagivationService : INagivationService
    {
        public void Navigate<TView, TViewModel>() where TView : Page where TViewModel : ViewModel
        {
            var mainVm = App.Current.MainWindow.DataContext as MainWindowViewModel;
            if (mainVm is not null)
            {
                mainVm!.CurrentPage = App.MainContainer.GetInstance<TView>();
                mainVm.CurrentPage.DataContext = App.MainContainer.GetInstance<TViewModel>();
            }
        }
    }
}
