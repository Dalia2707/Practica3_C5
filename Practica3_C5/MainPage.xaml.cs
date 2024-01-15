using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Practica3_C5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string nombre = Nombre.Text;
            string critica = nombre + "," + " es ";
            
            if (Hombre.IsChecked)
            {
                if (Alto.IsChecked)
                {
                    critica += "alto, ";
                }
                if (Listo.IsChecked)
                {
                    critica += "listo, ";
                }
                if (Raro.IsChecked)
                {
                    critica += "raro, ";
                }
                if (Feo.IsChecked)
                {
                    critica += "feo, ";
                }
                if(Extravagante.IsChecked)
                {
                    critica += "esxtravagante, ";
                }
                if (Grande.IsChecked)
                {
                    critica += "grande, ";
                }
            }
            if (Mujer.IsChecked)
            {
                if (Alto.IsChecked)
                {
                    critica += "alta, ";
                }
                if (Listo.IsChecked)
                {
                    critica += "lista, ";
                }
                if (Raro.IsChecked)
                {
                    critica += "rara, ";
                }
                if (Feo.IsChecked)
                {
                    critica += "fea, ";
                }
                if (Extravagante.IsChecked)
                {
                    critica += "extravagante, ";
                }
                if (Grande.IsChecked)
                {
                    critica += "grande, ";
                }
            }
            string resultado = critica.TrimEnd(' ', ',');

            if (!string.IsNullOrWhiteSpace(resultado))
            {
                int ucoma = resultado.LastIndexOf(',');
                if (ucoma > 0)
                {
                    resultado = $"{resultado.Substring(0, ucoma)} y {resultado.Substring(ucoma + 1)}";
                }
            }

            Critica.Text = resultado + ".";
        }
    }
}
