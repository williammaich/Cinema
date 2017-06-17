using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cinema.Views

{

    public class Filme
    {
        public string nome { get; set; }
        public decimal preco { get; set; }
        public string PrecoFormatado
        {
            get
            {
                return string.Format("R$ {0}", preco);
            }


        }



        public FormattedString FilmeLabel
        {
            get
            {
                return new FormattedString
                {

                    Spans = {
                        new Span{Text = nome},
                        new Span{Text = " - "},
                        new Span{Text = PrecoFormatado, FontAttributes = FontAttributes.Bold } }

                };
            }


            set { }
        }

    }




    public partial class ListagemView : ContentPage
    {
        public List<Filme> Filmes { get; set; }

        public ListagemView()
        {
            InitializeComponent();

            this.Filmes = new List<Filme>()
            {
                 new Filme {nome = "Mulher Maravilha", preco= 12},
                new Filme {nome = "Guardiões das galaxias vol 2", preco= 12},
                new Filme {nome = "Alien", preco= 12}
            };
            this.BindingContext = this;

        }



        private void listViewFilmes_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var filme = (Filme)e.Item;
            Navigation.PushAsync(new DetalheView(filme));
        }
    }
}
