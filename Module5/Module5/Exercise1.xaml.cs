using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercise1 : ContentPage
    {
        public Exercise1()
        {
            InitializeComponent();
        }
        private void OnGenderToggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                // Switch is turned on, do something
                var selectedGender = "Male";

                if (!genderSwitch.IsToggled)
                {
                    selectedGender = "Female";
                }

                // Do something with the selected gender
            }
        }
    }
}