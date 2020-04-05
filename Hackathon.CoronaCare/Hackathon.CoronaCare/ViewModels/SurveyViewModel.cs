/**

be aware that this code is only developed for some screenshots.. whithing some minuts.. 

created for hackathn <3 by Besnik Istrefi

 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Hackathon.CoronaCare.ViewModels
{
    public class SurveyViewModel : BaseViewModel
    {
        public ICommand FeelingGoodCmd { get;}
        public ICommand FeelingGoodCmd2 { get; }
        public SurveyViewModel()
        {
            FeelingGoodCmd = new Command(async () => await Application.Current.MainPage.DisplayAlert("Feeling", "We are glad you are feeling better. Do you still have any symptoms?", "Yes","No"));
            FeelingGoodCmd2 = new Command(async () => await Application.Current.MainPage.DisplayAlert("Contact Hotline", "If your symptoms are severe we recommend you to contact the COVID-19 Hotline in your canton", "Yes","No"));
        }

	}
}
