using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ButtonBMI.Clicked += ButtonBmiEvent;
            ButtonBMI2.Clicked += ButtonClickEvent2;
        }

        private void ButtonClickEvent2(object sender, EventArgs e)
        {
            float height = float.Parse(EntryHeight.Text);
            float weight = float.Parse(Entry.Text);

            if (height <= 3)
            {
                LabelResult.Text = "" + weight / (height * height);
                float BMI = weight / (height * height);
                Navigation.PushModalAsync(new NavigationPage(new BmiResult(BMI)));
            }
            else
            {
                height = height / 100;
                LabelResult.Text = "" + weight / (height * height);
                float BMI = weight / (height * height);
                Navigation.PushModalAsync(new NavigationPage(new BmiResult(BMI)));
            }


            
            
        }
        private void ButtonBmiEvent(object sender, EventArgs e)
        {

            float height = float.Parse(EntryHeight.Text);
            float weight = float.Parse(Entry.Text);

            if (height <= 3)
            {
               LabelResult.Text = "" + weight / (height * height);
            }
            else
            {
                height = height / 100;
                LabelResult.Text = "" + weight / (height * height);
            }
        }
    }
}
