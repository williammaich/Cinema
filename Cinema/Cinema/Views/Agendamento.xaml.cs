using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.Views
{
	
	public partial class Agendamento : ContentPage
	{

        public Filme Filme { get; set; }
        public string Nome { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }
        DateTime dataAgendamento = DateTime.Today;
        public DateTime DataAgendamento
        {
            get
            {
                return dataAgendamento;
            }
            set
            {
                dataAgendamento = value;
            }
        }

        TimeSpan horaAgendamento = TimeSpan.Zero;
        public TimeSpan HoraAgendamento
        {
            get
            {
                return horaAgendamento;
            }
            set
            {
                horaAgendamento = value;
            }
        }



		public Agendamento (Filme filme)
		{
            this.Filme = filme;
			InitializeComponent ();
            this.BindingContext = this;
		}

        private void Button_Clicked(object sender, EventArgs e)
        {

            DisplayAlert("Salvar Agendamento", string.Format(@"Nome: {0}   
Fone:{1}
Email:{2}
Data:{3} 
Hora:{4}
Filme: {5}", Nome, Fone, Email, DataAgendamento.ToString("dd/MM/yyyy"), HoraAgendamento, Filme.nome), "OK");


        }
    }
}