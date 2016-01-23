using HtmlAgilityPack;
using MgmUtils.PlacesModels;

namespace MgmUtils
{
    public class PlacesParser
    {
        public static Places Parse(ref string html, string placeName)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            Places places = new Places();

            HtmlNodeCollection cityNodes = doc.DocumentNode.SelectNodes("//*[@id = 'divSecim520Il']//ul//li//a");
            HtmlNodeCollection districtNodes = doc.DocumentNode.SelectNodes("//*[@id = 'divSecim520Ilce']//ul//li//a");
            foreach (HtmlNode cityNode in cityNodes)
            {
                City city = new City();
                city.Name = cityNode.InnerText;
                city.Href = cityNode.Attributes["href"].Value;
                places.Cities.Add(city);
            }
            foreach (HtmlNode districtNode in districtNodes)
            {
                District district = new District();
                district.Name = districtNode.InnerText;
                district.Href = districtNode.Attributes["href"].Value;
                places.Districts.Add(district);
            }
            return places;
        }
    }
}
