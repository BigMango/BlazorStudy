using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorStudy.Shared.Model;

namespace BlazorStudy.Shared.Services
{
    public interface IWeatherForecastService
    {
        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate);
    }
}
