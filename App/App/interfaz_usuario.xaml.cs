﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class interfaz_usuario : ContentPage
	{
        public interfaz_usuario()
        {
            InitializeComponent();
        }
            private async void Votaciones(object sender, EventArgs e)
            {
                string[] resultado = new string[100];

                int condicion = 2;
                string a = Conectar.Union(3, null);
                int poscoma = a.IndexOf(",");
                condicion = int.Parse(a.Substring(0, poscoma));
                a = a.Substring(poscoma + 1);

                await Navigation.PushAsync(new Votar(resultado, a, condicion, poscoma, 0));
            }
            private async void VotFut(object sender, EventArgs e)
            {
                string[] resultado = new string[100];
                string a = Conectar.Union(5, null);
                int poscoma = a.IndexOf(",");
                int condicion = int.Parse(a.Substring(0, poscoma));
                a = a.Substring(poscoma + 1);

                await Navigation.PushAsync(new Votar(resultado, a, condicion, poscoma, 1));
            }
            private async void Result(object sender, EventArgs e)
            {
                string[] resultado = new string[100];

                int condicion = 2;
                string a = Conectar.Union(6, null);
                int poscoma = a.IndexOf(",");
                condicion = int.Parse(a.Substring(0, poscoma));
                a = a.Substring(poscoma + 1);
                await Navigation.PushAsync(new Votar(resultado, a, condicion, poscoma, 2));

            }
        }
    }
	
