using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using Appmenuhamburguer.Views;

namespace Appmenuhamburguer
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Inicial)));
   
        }
  
    private async void Open_Inicial(object sender, EventArgs e)
        {
           try
           {
                Detail = new NavigationPage((Page)Activator.CreateInstace(typeof(Inicial)));
                IsPresented = false;
           }

           catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

            private async void Open_Segundo(object sender, EventArgs e)
            {
                try
                {
                    Detail = new NavigationPage((Page)Activator.CreateInstace(typeof(ComponentesSegundo)));
                    IsPresented = false;
                }

                catch (Exception ex)
                {
                    await DisplayAlert("Ops!", ex.Message, "OK");
                }

                private async void Open_Terceiro(object sender, EventArgs e)
                {
                    try
                    {
                        Detail = new NavigationPage((Page)Activator.CreateInstace(typeof(ComponentesTerceiro)));
                                                                                                          
                        IsPresented = false;
                    }

                    catch (Exception ex)
                    {
                        await DisplayAlert("Ops!", ex.Message, "OK");
                    }
                    private async void Open_Vestibulinho(object sender, EventArgs e)
                    {
                        try
                        {
                            Detail = new NavigationPage((Page)Activator.CreateInstace(typeof(Vestibulinho)));
                            IsPresented = false;
                        }

                        catch (Exception ex)
                        {
                            await DisplayAlert("Ops!", ex.Message, "OK");
                        }

                    }


                    private async void Open_Contato(object sender, EventArgs e)
                    {
                        try
                        {
                            Detail = new NavigationPage((Page)Activator.CreateInstace(typeof(Contato)));
                            IsPresented = false;
                        }

                        catch (Exception ex)
                        {
                            await DisplayAlert("Ops!", ex.Message, "OK");
                        }






                    }

                }
