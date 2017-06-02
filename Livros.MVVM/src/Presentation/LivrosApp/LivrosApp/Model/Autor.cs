using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LivrosApp.Model
{
    public class Autor : ModelBase, INotifyPropertyChanged
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set
            {
                nome = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Nome)));
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
