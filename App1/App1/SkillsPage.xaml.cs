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

            Skill skillComputerRepair = new Skill
            {
                Description = "Gained Experience at Gorilla Geeks",
                Name = "Computer Repair",
                Image = "Service.png"
            };
            Skill skillUIDesign = new Skill
            {
                Description = "Prior Creation of UI's for Applications",
                Name = "UI Design",
                Image = "UI.png"
            };
            Skill skillAudioEditing = new Skill
            {
                Description = "Mixing and Mastering Audio",
                Name = "Audio Editing",
                Image = "Audio.png"
            };
            Skill skillCustomerService = new Skill
            {
                Description = "Provided Help for Countless Clients",
                Name = "Customer Service",
                Image = "Face.png"
            };
            Skill skillProgrammingExperience = new Skill
            {
                Description = "Using C#, Visual Basic, and Robot C",
                Name = "Programming Experience",
                Image = "Code.png"
            };
            Skill skillCADTechnician = new Skill
            {
                Description = "Knowledge of Inventor, SolidWorks and Revit",
                Name = "CAD Technician",
                Image = "Cad.png"
            };
            Skill skillElectronicsBuilder = new Skill
            {
                Description = "Robotics Creations in Arduino",
                Name = "Electronics Builder",
                Image = "Bolt.png"
            };
            this.Skills.Add(skillComputerRepair);
            this.Skills.Add(skillUIDesign);
            this.Skills.Add(skillAudioEditing);
            this.Skills.Add(skillCustomerService);
            this.Skills.Add(skillProgrammingExperience);
            this.Skills.Add(skillCADTechnician);
            this.Skills.Add(skillElectronicsBuilder);

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