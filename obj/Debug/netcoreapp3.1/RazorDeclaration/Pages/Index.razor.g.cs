#pragma checksum "D:\L_SCHIAVON_DOCUMENTS\LAVORO\GIT\BLAZOR\MS_CollectingPoints\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1578acd05aa7a9eb96a852f55a59418827b30672"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 3 "D:\L_SCHIAVON_DOCUMENTS\LAVORO\GIT\BLAZOR\MS_CollectingPoints\Pages\Index.razor"
using Entities = MS_CollectingPoints.DataLayer.Data.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "D:\L_SCHIAVON_DOCUMENTS\LAVORO\GIT\BLAZOR\MS_CollectingPoints\Pages\Index.razor"
       

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


        List<Entities.App> LstApp3 = AppManager.GetAllBasePageEntities().ToList();

        CampaignManager.AddCampaign(new Entities.Campaign() {CampaignName="campagna2",IdApp=1 });

        
        //if (user.IsInRole("Publisher"))
        //    IsPublisher = true;

        //if ((await authorizationService.AuthorizeAsync(user, "SeniorEmployee")).Succeeded)
        //    IsSeniorEmployee = true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MS_CollectingPoints.BusinessLayer.Managers.ICampaignManager CampaignManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MS_CollectingPoints.BusinessLayer.Managers.IAppManager AppManager { get; set; }
    }
}
#pragma warning restore 1591
