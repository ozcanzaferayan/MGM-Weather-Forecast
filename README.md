# MGM Weather Forecast API
Gets weather forecast from http://www.mgm.gov.tr/tahmin/il-ve-ilceler.aspx

Nuget package: https://www.nuget.org/packages/MgmWeatherForecast/

WCF Service URL: http://forecast.zaferayan.com/WeatherService.svc

## API Functions
### Forecast GetForecastAsync(string uppercasePlaceName)
Gets the uppercasePlaceName's weather forecast.
* Sample usage:<code>await GetForecastAsync("ISTANBUL");</code>
http://forecast.zaferayan.com/WeatherService.svc/XML/forecast/ISTANBUL

### Places GetPlacesAsync(string uppercaseCityName)
Gets all cities and Ankara's district names.
* Sample usage:<code>await GetPlacesAsync("ANKARA");</code>
http://forecast.zaferayan.com/WeatherService.svc/JSON/places/ANKARA

## Sample Projects
### Console application
* First create console project:

![alt tag](https://raw.githubusercontent.com/ozcanzaferayan/MGM-Weather-Forecast/master/Screenshots/1%20-%20Creating%20project.png)

* Add MGM Weather Forecast nuget package:

![alt tag](https://raw.githubusercontent.com/ozcanzaferayan/MGM-Weather-Forecast/master/Screenshots/2.%20Manage%20nuget%20packages.png)
![alt tag](https://raw.githubusercontent.com/ozcanzaferayan/MGM-Weather-Forecast/master/Screenshots/3.%20Search%20package.png)

* Get current temperature:

![alt tag](https://raw.githubusercontent.com/ozcanzaferayan/MGM-Weather-Forecast/master/Screenshots/4.%20Get%20current%20temperature.png)
