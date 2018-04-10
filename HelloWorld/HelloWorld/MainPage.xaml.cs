using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.Reflection;
using System.IO;

namespace A4AA_Application
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			var layout = new StackLayout { Padding = new Thickness(5.0, 10.0) };

			Button button = new Button//here
			{
				Text = "Go to login Page!",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				BorderWidth = 1,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				TextColor = Color.Red
			};
			button.Clicked += OnClicked1;//to here
			layout.Children.Add(button);

			Button button2 = new Button//here
			{
				Text = "Go to Survey Page!",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				BorderWidth = 1,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				TextColor = Color.Red
			};
			button.Clicked += OnClicked2;//to here
			layout.Children.Add(button2);

		}

		async void OnClicked1(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new Login.LoginPage());
		}

		async void OnClicked2(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new SurveyPages.MainSurveyPage());
		}
	}
}
