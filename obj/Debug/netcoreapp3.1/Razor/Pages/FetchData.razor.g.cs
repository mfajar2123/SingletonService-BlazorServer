#pragma checksum "D:\Tes Magang\BlazorCommentsApp\Pages\FetchData.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "cfbef8aca160e5dc1486384bba948f376c7b7f74242a6f78edc668691fca21db"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCommentsApp.Pages
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Tes Magang\BlazorCommentsApp\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "D:\Tes Magang\BlazorCommentsApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 3 "D:\Tes Magang\BlazorCommentsApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 4 "D:\Tes Magang\BlazorCommentsApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 5 "D:\Tes Magang\BlazorCommentsApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 6 "D:\Tes Magang\BlazorCommentsApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 7 "D:\Tes Magang\BlazorCommentsApp\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 8 "D:\Tes Magang\BlazorCommentsApp\_Imports.razor"
using BlazorCommentsApp

#nullable disable
    ;
#nullable restore
#line 9 "D:\Tes Magang\BlazorCommentsApp\_Imports.razor"
using BlazorCommentsApp.Shared

#nullable disable
    ;
#nullable restore
#line 3 "D:\Tes Magang\BlazorCommentsApp\Pages\FetchData.razor"
 using BlazorCommentsApp.Data

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "D:\Tes Magang\BlazorCommentsApp\Pages\FetchData.razor"
      "/fetchdata"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class FetchData : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>\r\n\r\n");
#nullable restore
#line 10 "D:\Tes Magang\BlazorCommentsApp\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable

            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 13 "D:\Tes Magang\BlazorCommentsApp\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable

            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 26 "D:\Tes Magang\BlazorCommentsApp\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable

            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 29 "D:\Tes Magang\BlazorCommentsApp\Pages\FetchData.razor"
                         forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 30 "D:\Tes Magang\BlazorCommentsApp\Pages\FetchData.razor"
                         forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 31 "D:\Tes Magang\BlazorCommentsApp\Pages\FetchData.razor"
                         forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 32 "D:\Tes Magang\BlazorCommentsApp\Pages\FetchData.razor"
                         forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 34 "D:\Tes Magang\BlazorCommentsApp\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable

            __builder.AddContent(27, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 37 "D:\Tes Magang\BlazorCommentsApp\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable

        }
        #pragma warning restore 1998
#nullable restore
#line 39 "D:\Tes Magang\BlazorCommentsApp\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 4 "D:\Tes Magang\BlazorCommentsApp\Pages\FetchData.razor"
        WeatherForecastService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 4 "D:\Tes Magang\BlazorCommentsApp\Pages\FetchData.razor"
                               ForecastService

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591
