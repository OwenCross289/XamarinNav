using System;
using System.Collections.Generic;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;

namespace NavigationForms.Views
{
    public partial class MainView : ContentPage
    {
		public MainView()
			=> InitializeComponent();

		void OnLeftButtonClicked(object sender, EventArgs e)
		{
			if(SideMenuView.State == SideMenuState.LeftMenuShown)
            {
				SideMenuView.State = SideMenuState.MainViewShown;

			}
            else
            {
				SideMenuView.State = SideMenuState.LeftMenuShown;
			}
			
		}

		void CloseLeftMenu(object sender, EventArgs e)
			=> SideMenuView.State = SideMenuState.MainViewShown;
	}
}
