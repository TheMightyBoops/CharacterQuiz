using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FanQuiz
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        Question CurrentQuestion { get; set; }
    }
}
