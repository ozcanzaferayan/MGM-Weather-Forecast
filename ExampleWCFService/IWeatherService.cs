using MgmUtils.Models;
using MgmUtils.PlacesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
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
