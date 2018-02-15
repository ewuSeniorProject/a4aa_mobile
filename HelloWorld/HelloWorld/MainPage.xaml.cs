using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace HelloWorld
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
		{
			InitializeComponent();
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
