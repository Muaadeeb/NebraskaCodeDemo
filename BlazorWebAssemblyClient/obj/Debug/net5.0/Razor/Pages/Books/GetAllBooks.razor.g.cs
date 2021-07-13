#pragma checksum "C:\Users\Owner\source\repos\NebraskaCodeDemo\BlazorWebAssemblyClient\Pages\Books\GetAllBooks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afb750660ab359240af0470e1fe244b20513cd53"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWebAssemblyClient.Pages.Books
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Owner\source\repos\NebraskaCodeDemo\BlazorWebAssemblyClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Owner\source\repos\NebraskaCodeDemo\BlazorWebAssemblyClient\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Owner\source\repos\NebraskaCodeDemo\BlazorWebAssemblyClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Owner\source\repos\NebraskaCodeDemo\BlazorWebAssemblyClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Owner\source\repos\NebraskaCodeDemo\BlazorWebAssemblyClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Owner\source\repos\NebraskaCodeDemo\BlazorWebAssemblyClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Owner\source\repos\NebraskaCodeDemo\BlazorWebAssemblyClient\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Owner\source\repos\NebraskaCodeDemo\BlazorWebAssemblyClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Owner\source\repos\NebraskaCodeDemo\BlazorWebAssemblyClient\_Imports.razor"
using BlazorWebAssemblyClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Owner\source\repos\NebraskaCodeDemo\BlazorWebAssemblyClient\_Imports.razor"
using BlazorWebAssemblyClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Owner\source\repos\NebraskaCodeDemo\BlazorWebAssemblyClient\_Imports.razor"
using ModelDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Owner\source\repos\NebraskaCodeDemo\BlazorWebAssemblyClient\_Imports.razor"
using BlazorWebAssemblyClient.Services.Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/books/getallbooks")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/getallbooks")]
    public partial class GetAllBooks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>GetAllBooks</h3>");
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\Owner\source\repos\NebraskaCodeDemo\BlazorWebAssemblyClient\Pages\Books\GetAllBooks.razor"
       
    
    public List<BookDTO> Books { get; set; }


    protected override async Task OnInitializedAsync()
    {
        try
        {
            Books = await _bookService.GetAllBooksAsync();
        }
        catch(Exception ex)
        {
            throw new Exception("Something bad happened here: " + ex.Message);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookService _bookService { get; set; }
    }
}
#pragma warning restore 1591
