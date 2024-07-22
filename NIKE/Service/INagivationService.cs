using NIKE.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace NIKE.Service
{
    public interface INagivationService
    {
        void Navigate<TView, TViewModel>() where TView : Page where TViewModel : ViewModel;
    }
}
