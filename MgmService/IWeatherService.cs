﻿using MgmUtils.Models;
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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWeatherService
    {
        [OperationContract]
        Task<Forecast> GetWeatherForecastAsync(string placeName = "");

        [OperationContract]
        Task<Places> GetPlacesAsync(string placeName = "");
    }
}
