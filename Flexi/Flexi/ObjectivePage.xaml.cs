﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Flexi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ObjectivePage : ContentPage
    {
        public ObjectivePage()
        {
            InitializeComponent ();
        }

        private void onObjectiveDone_Clicked(object sender, EventArgs e)
        {

        }
    }
}