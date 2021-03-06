﻿using System;
using System.Net;
using Xamarin.Forms;
using Xamarin.Forms.CommonCore;

namespace referenceguide
{
	public class MainPage : MasterDetailPage
	{
		public static Page CurrentDetail { get; set; }
		public MainPage()
		{
			try
			{
				Master = new SlidingPage();
				Detail = new NavigationPage(new LandingPage())
				{
					BarBackgroundColor = Color.FromHex("#b85921"),
					BarTextColor = Color.White
				};
				AppData.AppNav = Detail.Navigation;
				MainPage.CurrentDetail = Detail;
			}
			catch (Exception ex)
			{
				var x = ex.Message;
			}

		}

	}
}
