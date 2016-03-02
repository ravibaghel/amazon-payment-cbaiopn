using System;
using System.Web;
using System.Web.UI;

namespace cbaiopn.web
{
	
	public partial class Default : System.Web.UI.Page
	{
		public void button1Clicked (object sender, EventArgs args)
		{
			button1.Text = "You clicked me";
		}
	}
}

