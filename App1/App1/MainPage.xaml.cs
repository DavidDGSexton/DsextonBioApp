using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void homeaboutButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutMePage());
        }

        private void ContactLabel_Tap(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new ContactPopup());
        }

        private void SkillsButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SkillsPage());
        }

        private void ContactButton_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new ContactPopup());
        }
    }
}
