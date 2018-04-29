using ACENDE_TE.SESAMO.Mobile.Services;
using ACENDE_TE.SESAMO.Mobile.Models;
using Prism.Navigation;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace ACENDE_TE.SESAMO.Mobile.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ICommand TurnOnCommand { get; set;}
        public ICommand TurnOffCommand { get; set;}
            
        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Main Page";

            TurnOnCommand = new Command(TurnOn);
            TurnOffCommand = new Command(TurnOff);
        }

        public async void TurnOn()
        {
            try
            { 
                var light = new Light()
                {
                    Action = 1
                };

                await ServiceGenerator.GetService().Test(light);
            }
            catch(Exception ex)
            {
            }
        }

        public async void TurnOff()
        {
            try
            { 
                var light = new Light()
                {
                    Action = 0
                };

                await ServiceGenerator.GetService().Test(light);
            }
            catch(Exception ex)
            {
            }
        }
    }
}
