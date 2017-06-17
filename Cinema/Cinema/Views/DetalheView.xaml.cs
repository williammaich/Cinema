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

        private const int VALOR_2D = 0;
        private const int VALOR_3D = 6;
        private const int VALOR_MEIA3D = 9;
        private const int VALOR_MEIA2D = 6;
        private const int VALOR_PIPOCA = 15;
        private const int VALOR_PIPOCAGRANDE = 20;
        private const int VALOR_REFRI = 5;
        private const int VALOR_COMBO = 18;

        public string Texto2D
        {
            get
            {
                return string.Format("Filme 2D - R$ 12", VALOR_2D);
            }
        }

        public string Texto3D
        {
            get
            {
                return string.Format("Filme 3D - R$ {0}", VALOR_3D);
            }
        }

        public string TextoMeia2D
        {
            get
            {
                return string.Format("Filme Meia entrada 2D - R$ {0}", VALOR_MEIA2D);
            }
        }


        public string TextoMeia3D
        {
            get
            {
                return string.Format("Filme Meia entrada 3D - R$ {0}", VALOR_MEIA3D);
            }
        }

        public string TextoPipoca
        {
            get
            {
                return string.Format("Pipoca Media - R$ {0}", VALOR_PIPOCA);
            }
        }

        public string TextoPipocaGrande
        {
            get
            {
                return string.Format("Pipoca Grande - R$ {0}", VALOR_PIPOCAGRANDE);
            }
        }

        public string TextoRefri
        {
            get
            {
                return string.Format("Refrigerante - R$ {0}", VALOR_REFRI);
            }
        }

        public string TextoCombo
        {
            get
            {
                return string.Format("Combo - R$ {0}", VALOR_COMBO);
            }
        }

        bool tem2D;
        public bool Tem2D
        {
            get
            {
                return tem2D;
            }

            set
            {
                tem2D = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(PrecoTotalFormatado));
            }

        }

        bool tem3D;
        public bool Tem3D
        {
            get
            {
                return tem3D;
            }

            set
            {
                tem3D = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(PrecoTotalFormatado));
            }

        }

        bool temMeia2D;
        public bool TemMeia2D
        {
            get
            {
                return temMeia2D;
            }

            set
            {
                temMeia2D = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(PrecoTotalFormatado));
            }

        }

        bool temMeia3D;
        public bool TemMeia3D
        {
            get
            {
                return temMeia3D;
            }

            set
            {
                temMeia3D = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(PrecoTotalFormatado));
            }

        }

        bool temPipoca;
        public bool TemPipoca
        {
            get
            {
                return temPipoca;
            }

            set
            {
                temPipoca = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(PrecoTotalFormatado));
            }

        }

        bool temPipocaGrande;
        public bool TemPipocaGrande
        {
            get
            {
                return temPipocaGrande;
            }

            set
            {
                temPipocaGrande = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(PrecoTotalFormatado));
            }

        }

        bool temRefri;
        public bool TemRefri
        {
            get
            {
                return temRefri;
            }

            set
            {
                temRefri = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(PrecoTotalFormatado));
            }

        }


        bool temCombo;
        public bool TemCombo
        {
            get
            {
                return temCombo;
            }

            set
            {
                temCombo = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(PrecoTotalFormatado));
            }

        }


        public decimal PrecoTotal
        {
            get
            {
                return Filme.preco + (Tem2D ? VALOR_2D : 0)
                                   + (Tem3D ? VALOR_3D : 0)
                                    - (TemMeia2D ? VALOR_MEIA2D : 0)
                                     - (TemMeia3D ? VALOR_MEIA3D : 0)
                                     + (TemPipoca ? VALOR_PIPOCA : 0)
                                     + (TemPipocaGrande ? VALOR_PIPOCAGRANDE : 0)
                                     + (TemRefri ? VALOR_REFRI : 0)
                                     + (TemCombo ? VALOR_COMBO : 0);

            }
        }

        public string PrecoTotalFormatado
        {
            get
            {
                return string.Format("Total: R$ {0}", PrecoTotal);
            }
        }


        public DetalheView(Filme filme)
        {
            this.Filme = filme;
            InitializeComponent();
            this.BindingContext = this;
        }


        private void botaoProximo_Clicked(object sender, EventArgs e)

        {

            Navigation.PushAsync(new Agendamento(this.Filme));


        }
    }
}