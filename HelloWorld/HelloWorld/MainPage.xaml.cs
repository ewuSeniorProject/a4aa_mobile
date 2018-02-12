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
            simpleJsonClass sjc = new simpleJsonClass(userEntry);
            var actualJSON = JsonConvert.SerializeObject(sjc);

            var content = new StringContent(actualJSON, Encoding.UTF8, "application/x-www-form-urlencodeed");

            var client = new HttpClient();
            var response = await client.PostAsync("http://mizesolutions.com/a4aa1/a4aa/src/a4aa_rec.php", content);
            var result = JsonConvert.DeserializeObject<int>(response.Content.ReadAsStringAsync().Result);

            resLabel.Text = result.ToString();
        }
    }
}
