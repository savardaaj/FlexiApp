using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Flexi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent ();
            
        }

        async void BtnManageObjectives_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ObjectiveListPage
            {
                //BindingContext = new Models.Objective()
            });
        }

        async void BtnManageBlocks_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BlockListPage
            {
                //BindingContext = new Models.Block()
            });
        }
    }
}
