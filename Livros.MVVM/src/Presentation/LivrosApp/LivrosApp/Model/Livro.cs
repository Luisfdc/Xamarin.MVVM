using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LivrosApp.Model
{
    public class Livro: ModelBase, INotifyPropertyChanged
    {
        private string titulo;
        public string Titulo
        {
            get { return titulo; }
            set
            {
                titulo = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Titulo)));
            }

        }

        public Autor Autor { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
