using LivrosApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace LivrosApp.ViewModel
{
    public class LivrosViewModel
    {
        public ICommand CarregarLivros { get; set; }
        public ObservableCollection<Livro> Livros { get; set; }

        public LivrosViewModel()
        {
            Livros = new ObservableCollection<Livro>();

            Livros.Add(new Livro { Id = Livros.Count + 1, Titulo = $"Livro {Livros.Count}" });

            CarregarLivros = new Xamarin.Forms.Command(() =>
            {
                Livros.Add(new Livro { Id = Livros.Count + 1, Titulo = $"Livro {Livros.Count}" });
            });
        }
    }
}
