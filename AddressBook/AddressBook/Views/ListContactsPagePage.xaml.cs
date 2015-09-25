using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AddressBook
{
	public partial class ListContactsPage : ContentPage
	{
		public ListContactsPage ()
		{
			InitializeComponent ();
		}

		private void ButtonClicked (object sender, EventArgs eventArgs)
		{
			Navigation.PushAsync (new ContactInfoPage ());
		}
	}
}

