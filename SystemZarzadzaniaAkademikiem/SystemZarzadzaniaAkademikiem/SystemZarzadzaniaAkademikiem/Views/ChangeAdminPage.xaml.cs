﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemZarzadzaniaAkademikiem.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SystemZarzadzaniaAkademikiem.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChangeAdminPage : ContentPage
	{
        AdminChangeViewModel viewModel;
        public ChangeAdminPage ()
		{
			InitializeComponent ();
            BindingContext = viewModel = new AdminChangeViewModel();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TablesPage());
        }
    }
}