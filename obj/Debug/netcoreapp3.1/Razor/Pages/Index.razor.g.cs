#pragma checksum "D:\L_SCHIAVON_DOCUMENTS\LAVORO\GIT\BLAZOR\MS_CollectingPoints\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e3f5cdd6c8b086cbb377d1b528757637b118d30"
// <auto-generated/>
#pragma warning disable 1591
namespace MS_CollectingPoints.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\L_SCHIAVON_DOCUMENTS\LAVORO\GIT\BLAZOR\MS_CollectingPoints\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\L_SCHIAVON_DOCUMENTS\LAVORO\GIT\BLAZOR\MS_CollectingPoints\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\L_SCHIAVON_DOCUMENTS\LAVORO\GIT\BLAZOR\MS_CollectingPoints\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\L_SCHIAVON_DOCUMENTS\LAVORO\GIT\BLAZOR\MS_CollectingPoints\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\L_SCHIAVON_DOCUMENTS\LAVORO\GIT\BLAZOR\MS_CollectingPoints\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\L_SCHIAVON_DOCUMENTS\LAVORO\GIT\BLAZOR\MS_CollectingPoints\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\L_SCHIAVON_DOCUMENTS\LAVORO\GIT\BLAZOR\MS_CollectingPoints\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\L_SCHIAVON_DOCUMENTS\LAVORO\GIT\BLAZOR\MS_CollectingPoints\_Imports.razor"
using MS_CollectingPoints;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\L_SCHIAVON_DOCUMENTS\LAVORO\GIT\BLAZOR\MS_CollectingPoints\_Imports.razor"
using MS_CollectingPoints.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\L_SCHIAVON_DOCUMENTS\LAVORO\GIT\BLAZOR\MS_CollectingPoints\Pages\Index.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 12 "D:\L_SCHIAVON_DOCUMENTS\LAVORO\GIT\BLAZOR\MS_CollectingPoints\Pages\Index.razor"
 if (IsUserAuthenticated)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "h3");
            __builder.OpenElement(2, "b");
            __builder.AddContent(3, 
#nullable restore
#line 14 "D:\L_SCHIAVON_DOCUMENTS\LAVORO\GIT\BLAZOR\MS_CollectingPoints\Pages\Index.razor"
            user.Identity.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(4, " is logged in!!!");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 17 "D:\L_SCHIAVON_DOCUMENTS\LAVORO\GIT\BLAZOR\MS_CollectingPoints\Pages\Index.razor"
                                                   
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.AddMarkupContent(7, "<h3><b>User is logged out</b></h3>\r\n");
#nullable restore
#line 22 "D:\L_SCHIAVON_DOCUMENTS\LAVORO\GIT\BLAZOR\MS_CollectingPoints\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "D:\L_SCHIAVON_DOCUMENTS\LAVORO\GIT\BLAZOR\MS_CollectingPoints\Pages\Index.razor"
       

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    ClaimsPrincipal user;

    bool IsUserAuthenticated;
    //bool IsPublisher;
    //bool IsSeniorEmployee;


    protected override async Task OnInitializedAsync()
    {
        user = (await authenticationStateTask).User;

        if (user.Identity.IsAuthenticated)
            IsUserAuthenticated = true;

        //if (user.IsInRole("Publisher"))
        //    IsPublisher = true;

        //if ((await authorizationService.AuthorizeAsync(user, "SeniorEmployee")).Succeeded)
        //    IsSeniorEmployee = true;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
