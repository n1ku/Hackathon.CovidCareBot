/**

be aware that this code is only developed for some screenshots.. whithing some minuts.. 

created for hackathn <3 by Besnik Istrefi

 */
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Hackathon.CoronaCare.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://xamarin.com"));
        }

        public ICommand OpenWebCommand { get; }
    }
}