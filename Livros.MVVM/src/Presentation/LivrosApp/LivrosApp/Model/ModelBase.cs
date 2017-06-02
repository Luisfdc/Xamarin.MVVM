using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LivrosApp.Model
{
    public class ModelBase: INotifyPropertyChanged
    {
        private int id;
        public int Id
        {
            get { return id; }
            set {
                id = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Id)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
