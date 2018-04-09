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

namespace HelloWorld
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
		{
			InitializeComponent();

			Button button = new Button//here
			{
				Text = "Go to login Page!",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				BorderWidth = 1,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				TextColor = Color.Red
			};
			button.Clicked += OnClicked;//to here
			

			var layout = new StackLayout { Padding = new Thickness(5.0, 10.0) };

			layout.Children.Add(button);//this

			var assembly = typeof(App).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("HelloWorld.Droid.surveyQuestions.txt");
            string text = "";
            
            using (var reader = new System.IO.StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }

            string[] separatedLines = text.Split('\n');

            foreach (string s in separatedLines)
            {
                //System.Diagnostics.Debug.WriteLine(s);
                var label = new Label { FontSize = 20 };
                var fs = new FormattedString();
                fs.Spans.Add(new Span { Text = s });
                label.FormattedText = fs;
                layout.Children.Add(label);

                var entry = new Entry { Placeholder = "Answer here..." };
                layout.Children.Add(entry);
            }

			

			var scrollView = new ScrollView { Content = layout };
            this.Content = scrollView;

			
		}

		async void OnClicked(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new Login.LoginPage());
		}

		private void Entry_Completed(object sender, EventArgs e)
        {
            String userEntry = ((Entry)sender).Text;
            sendAndResponse(userEntry);
        }
        
        private async void sendAndResponse(String userEntry)
        {
            using (var httpClient = new HttpClient())
            {
                simpleJsonClass sjc = new simpleJsonClass(userEntry);
                var uri = new Uri("http://mizesolutions.com/a4aa1/a4aa/src/a4aa_rec.php");
                var response = httpClient.PostAsync(uri, new StringContent(sjc.toJsonString(), Encoding.UTF8, "application/json")).Result;
                resLabel.Text = await response.Content.ReadAsStringAsync();
            }
        }
    }
}
