using MgmWeatherForecast.Models;
using MgmWeatherForecast.PlacesModels;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Threading.Tasks;

namespace MgmService
{
    [ServiceContract]
    public interface IWeatherService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/forecast/{placeName}")]
        Task<Forecast> GetWeatherForecastAsync(string placeName = "");

        
        [OperationContract]
        [WebGet(UriTemplate = "/placesList/{placeName}")]
        Task<Places> GetPlacesAsync(string placeName = "");
    }
}
