using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        WebService ws = new WebService();

        int value;
        if (int.TryParse(TextBox1.Text, out value) && int.TryParse(TextBox2.Text, out value))
        {
            Label1.Text = ws.add(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();
        }
        else
        {
            Label1.Text = "Make sure both fields are numeric";
        }
      

       

       


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            WeatherService.GlobalWeatherSoapClient ws = new WeatherService.GlobalWeatherSoapClient("GlobalWeatherSoap");

            Label2.Text = ws.GetWeather(cityTextBox.Text, countryTextBox.Text);
        }
        catch (Exception ex)
        {
            Label2.Text = "Check city and Country Name";
        }
    }
}
