﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.CommonCore;

namespace referenceguide
{
	public class MaterialDesignPage : AbsoluteLayoutPage<ControlsViewModel>
	{

		public MaterialDesignPage()
		{
			this.Title = "Material Design";

			var fab = new FABControl()
			{
				Size = FABControlSize.Normal,
				ColorNormal = Color.FromHex("#DF8049"),
				ColorPressed = Color.FromHex("#DF8049").MultiplyAlpha(0.4),
				ImageName = "plus.png"
			};

			fab.SetBinding(FABControl.CommandProperty, "FABClicked");
			AbsoluteLayout.SetLayoutFlags(fab, AbsoluteLayoutFlags.PositionProportional);
			AbsoluteLayout.SetLayoutBounds(fab, new Rectangle(0.95f, 0.95f, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));


			var fteUserName = new FTEControl()
			{
				Placeholder = "User Name",
				ErrorText = "Required Field",
				ErrorColor = Color.Red,
				Validator = FTEControl.RequiredValidator
			};

			var ftePassword = new FTEControl()
			{
				Placeholder = "Password",
				IsPassword = true,
				ErrorText = "Required Field",
				ErrorColor = Color.Red,
				Validator = FTEControl.RequiredValidator
			};


			Content = new StackLayout()
			{
				Padding = 10,
				Spacing = 25,
				Children = { fteUserName, ftePassword }
			};

			AbsoluteLayer.Children.Add(fab);
		}


	}
}