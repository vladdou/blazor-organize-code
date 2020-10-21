using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using ThreeWays.Data;
    
namespace ThreeWays.Pages
{
    public partial class  FetchData
    {
        private WeatherForecast[] forecasts;
        [Inject]
        public WeatherForecastService ForecastService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        }
    }
}