using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.Views
{
	
	public partial class DetalheView : ContentPage
	{
        public Filme Filme { get; set; }

        public DetalheView ( Filme filme)
		{
            this.Filme = filme;
          

			InitializeComponent ();
		}

      
    }
}