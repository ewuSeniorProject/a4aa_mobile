using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

/*
This is a comment being written by Blake,
who at this point is very tired of dealing with Github.
Seriously, who made this garbage?

"I have an idea, let's make some software no-one
understands how to use."

"Oh God, that's perfect developer2, great idea!"

Blake: "..."

Here's is more insane thoughts from your friend, Blake:
"Hi."
*/

namespace HelloWorld
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new HelloWorld.MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
