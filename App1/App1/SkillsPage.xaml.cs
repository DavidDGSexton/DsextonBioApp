using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SkillsPage : ContentPage
	{
        public ObservableCollection<Skill> Skills { get; set; }

		public SkillsPage ()
		{
			InitializeComponent ();

            this.Skills = new ObservableCollection<Skill>();

            Skill skill1 = new Skill
            {
                Description = "Test of Description",
                Name = "Test",
                Image = "https://image.flaticon.com/icons/svg/24/24143.svg"
            };
            this.Skills.Add(skill1);

            this.skillsList.ItemsSource = this.Skills;

        }

        public class Skill
        {
            public string Image { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }



    }
}