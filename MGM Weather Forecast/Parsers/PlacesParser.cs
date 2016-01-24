using HtmlAgilityPack;
using MgmWeatherForecast.PlacesModels;

namespace MgmWeatherForecast
{
    /// <summary>
    /// Using html for getting place informations.
    /// </summary>
    class PlacesParser
    {
        /// <summary>
        /// Parses the specified HTML which belongs http://www.mgm.gov.tr/tahmin/il-ve-ilceler.aspx site.
        /// </summary>
        /// <param name="html">The HTML string.</param>
        /// <returns>Place list within HTML page.</returns>
        public static Places Parse(ref string html)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            Places places = new Places();

            HtmlNodeCollection cityNodes = doc.DocumentNode.SelectNodes("//*[@id = 'divSecim520Il']//ul//li//a");
            HtmlNodeCollection districtNodes = doc.DocumentNode.SelectNodes("//*[@id = 'divSecim520Ilce']//ul//li//a");
            foreach (HtmlNode cityNode in cityNodes)
            {
                City city = new City();
                city.Name = cityNode.Attributes["href"].Value.Replace("?m=", "").Replace("#sfB", "");
                places.Cities.Add(city);
            }
            foreach (HtmlNode districtNode in districtNodes)
            {
                District district = new District();
                district.Name = districtNode.Attributes["href"].Value.Replace("?m=", "").Replace("#sfB", "");
                places.Districts.Add(district);
            }
            return places;
        }
    }
}
