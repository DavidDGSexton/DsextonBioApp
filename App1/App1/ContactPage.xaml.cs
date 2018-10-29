using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactPage : ContentPage
	{
		public ContactPage ()
		{
			InitializeComponent ();
		}

        private void SubmitButton_Pressed(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameEntry.Text))
            {
                DisplayAlert("Error!", "Please enter Name", "Ok!");
                return;
            }
            else if (string.IsNullOrEmpty(emailEntry.Text))
            {
                DisplayAlert("Error!", "Please enter email", "Ok!");
                return;
            }
            else if (string.IsNullOrEmpty(messageEditor.Text))
            {
                DisplayAlert("Error!", "Please enter message", "Ok!");
                return;
            }
            else
            {
                DisplayAlert("Alert!", "Your Message Was Sent", "Ok!");
                Navigation.PushAsync(new MainPage());
            }

            
        }
    }
}