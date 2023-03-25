using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Xamarin.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AppImc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            try
            {
                v_referencia.IsVisible = true;

                double altura = Convert.ToDouble(txt_altura.Text);
                double peso = Convert.ToDouble(txt_peso.Text);

                double imc = peso / (altura * altura);

                string classificacao = $"Seu IMC é {imc.ToString("0.00")} - ";

                if (imc < 17)
                {
                    classificacao += "Muito abaixo do peso.";
                }else if(imc >= 17 && imc <= 18.49){
                    classificacao += "Abaixo do peso. 😒";
                }else if(imc >= 18.5 && imc <= 24.99)
                {
                    classificacao += "Peso Normal. 😋";
                }else if(imc >= 25 && imc <= 29.99)
                {
                    classificacao += "Acima do Peso ";
                }else if (imc >= 30 && imc <= 34.99)
                {
                    classificacao += "Obesidade I. ";
                }else if (imc >= 35 && imc <= 39.99)
                {
                    classificacao += "Obesidade II. ";
                }else
                {
                    classificacao += "Obesidade III. ";
                }
                lbl_resultado.Text = classificacao;

            }
            catch(Exception ex)
            {
                lbl_resultado.Text = ex.Message;
            }


        }
    }
}
