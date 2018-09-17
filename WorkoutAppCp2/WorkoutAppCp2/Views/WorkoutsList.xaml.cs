﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutAppCp2.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkoutAppCp2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WorkoutsList : ContentPage
	{
		public WorkoutsList ()
		{
			InitializeComponent ();

		}
        protected override void OnAppearing()
        {
            this.BindingContext = new WorkoutsListViewModel(Navigation);
        }
    }
}