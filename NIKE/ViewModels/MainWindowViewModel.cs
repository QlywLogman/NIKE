using NIKE.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace NIKE.ViewModels
{
    public class MainWindowViewModel : ViewModel, INotifyPropertyChanged
    {
        private Page? currentPage;

        public Page? CurrentPage
        {
            get => currentPage;
            set { currentPage = value!; OnPropertyChanged(); }
        }

        private readonly INagivationService navigationService;

        public MainWindowViewModel(INagivationService navigationService)
        {
            this.navigationService = navigationService;

            //-----------------------------------------------------

            //-----------------------------------------------------
        }


        //-------------------------------------------------------------
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? paramName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(paramName));
        //-------------------------------------------------------------
    }
}
