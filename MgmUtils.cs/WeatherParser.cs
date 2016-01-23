using HtmlAgilityPack;
using MgmUtils.Models;

namespace MgmUtils
{
    public class WeatherParser
    {
        public static Forecast Parse(ref string html)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);//
            Forecast forecast = new Forecast();

            HtmlNodeCollection locationInfoNodes = doc.DocumentNode.SelectNodes("//*[contains(@id,'divMerkez')]//p");
            HtmlNode lastStatusTable = doc.DocumentNode.SelectSingleNode("//*[contains(@class,'tbl_sond')]");
            HtmlNodeCollection forecastCells = doc.DocumentNode.SelectNodes("//*[contains(@class,'tbl_thmn')]//tbody//*[local-name()='th' or local-name()='td']");
            forecast.LocationInfo = GetLocationInfo(locationInfoNodes);
            forecast.CurrentForecast = GetForecastLastStatus(lastStatusTable);
            forecast.FiveDayForecast = GetFiveDayForecast(forecastCells);
            return forecast;
        }

        private static LocationInfo GetLocationInfo(HtmlNodeCollection locationInfoNodes)
        {
            LocationInfo locationInfo = new LocationInfo();
            locationInfo.Altitude = locationInfoNodes[0].LastChild.InnerText.Substring(6);
            locationInfo.Longitude = locationInfoNodes[1].LastChild.InnerText.Substring(6);
            locationInfo.Latitude = locationInfoNodes[2].LastChild.InnerText.Substring(6);
            locationInfo.Sunset = locationInfoNodes[3].LastChild.InnerText.Substring(6);
            locationInfo.Sunrise = locationInfoNodes[4].LastChild.InnerText.Substring(6);
            return locationInfo;
        }

        private static ForecastCurrent GetForecastLastStatus(HtmlNode lastStatusTable)
        {
            ForecastCurrent lastStatus = new ForecastCurrent();
            HtmlNode lastStatusTableHeader = lastStatusTable.ChildNodes[1];
            HtmlNode lastStatusTableBody = lastStatusTable.ChildNodes[3];

            HtmlNode weatherTypeNode = lastStatusTableHeader.ChildNodes[5];

            HtmlNode statusTimeNode = lastStatusTableBody.ChildNodes[1];
            HtmlNode tempNode = lastStatusTableBody.ChildNodes[3];
            HtmlNode humidityNode = lastStatusTableBody.ChildNodes[5];
            HtmlNode windNode = lastStatusTableBody.ChildNodes[7];
            HtmlNode pressureNode = lastStatusTableBody.ChildNodes[9];
            HtmlNode sightNode = lastStatusTableBody.ChildNodes[11];

            lastStatus.Weather = weatherTypeNode.Attributes["title"].Value;
            lastStatus.Date = statusTimeNode.FirstChild.InnerText;
            lastStatus.Hour = statusTimeNode.LastChild.InnerText;
            lastStatus.Temperature = tempNode.InnerText;
            lastStatus.Humidity = humidityNode.InnerText;
            lastStatus.Wind.Direction = windNode.Attributes["title"].Value;
            lastStatus.Wind.Velocity = windNode.LastChild.InnerText;
            lastStatus.Pressure = pressureNode.InnerText;
            lastStatus.Sight = sightNode.InnerText;
            return lastStatus;
        }

        private static ForecastForFiveDays GetFiveDayForecast(HtmlNodeCollection forecastCells)
        {
            ForecastForFiveDays fiveDayForecast = new ForecastForFiveDays();
            for (int i = 0; i < forecastCells.Count; i += (forecastCells.Count / 5))
            {
                ForecastForDay tempForecast = new ForecastForDay();
                tempForecast.Date = forecastCells[i].InnerText;
                tempForecast.Daily.Temperature.Min = forecastCells[i + 1].InnerText;
                tempForecast.Daily.Temperature.Max = forecastCells[i + 2].InnerText;
                tempForecast.Daily.Weather = forecastCells[i + 3].Attributes["title"].Value;
                tempForecast.Daily.Humidity.Min = forecastCells[i + 4].InnerText;
                tempForecast.Daily.Humidity.Max = forecastCells[i + 5].InnerText;
                tempForecast.Daily.Wind.Direction = forecastCells[i + 6].Attributes["title"].Value;
                tempForecast.Daily.Wind.Velocity = forecastCells[i + 7].InnerText;
                tempForecast.History.Extremity.Min = forecastCells[i + 8].InnerText;
                tempForecast.History.Extremity.Max = forecastCells[i + 9].InnerText;
                tempForecast.History.Average.Min = forecastCells[i + 10].InnerText;
                tempForecast.History.Average.Max = forecastCells[i + 11].InnerText;
                fiveDayForecast.Forecasts[i / 11] = tempForecast;
            }
            return fiveDayForecast;
        }
    }
}
