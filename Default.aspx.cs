using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

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
        //create object of webservice client
        WeatherService2.WeatherSoapClient ws = new WeatherService2.WeatherSoapClient("WeatherSoap");

       //variable to store the zip entered by user
       String zip = zipTextbox.Text;
       
       //Regex object to set pattern to compare zip to
       Regex rgx = new Regex(@"^\d{5}(?:[-\s]\d{4})?$");

            //if zip is not empty and matches the regex retrieve weather data
            if (!zip.Equals("") && rgx.IsMatch(zip))
            {
                String city = ws.GetCityWeatherByZIP(zip).City;
                String state = ws.GetCityWeatherByZIP(zip).State;
                String weatherStationCity = ws.GetCityWeatherByZIP(zip).WeatherStationCity;
                String description = ws.GetCityWeatherByZIP(zip).Description;
                String temperature = ws.GetCityWeatherByZIP(zip).Temperature;
                String relativeHumidity = ws.GetCityWeatherByZIP(zip).RelativeHumidity;
                String wind = ws.GetCityWeatherByZIP(zip).Wind;
                String pressure = ws.GetCityWeatherByZIP(zip).Pressure;

                //display weather data in webform labels
                cityLabel.Text = "City: "+city;
                stateLabel.Text = "State: "+state;
                weatherStationCityLabel.Text = "Weather Station City: "+weatherStationCity;
                descriptionLabel.Text = "Description: "+description;
                temperatureLabel.Text = "Temperature: "+temperature;
                relativeHumidityLabel.Text = "Relative Humidity: "+relativeHumidity;
                windLabel.Text = "Wind "+wind;
                pressureLabel.Text = "Pressure: "+pressure;

            }
            else
            {
                //if zip is not valid display invalid zip label
                invalidZipLabel.Text = "Please enter a valid zip code";
                cityLabel.Text = "";
                stateLabel.Text = "";
                weatherStationCityLabel.Text = "";
                descriptionLabel.Text = "";
                temperatureLabel.Text = "";
                relativeHumidityLabel.Text = "";
                windLabel.Text = "";
                pressureLabel.Text = "";
            }
    }
}
