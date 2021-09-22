using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace App3.ModelViews
{
    class BaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string cambio) {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(cambio));
        }
    }
}
