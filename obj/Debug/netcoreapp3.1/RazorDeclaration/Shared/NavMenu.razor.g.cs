#pragma checksum "D:\L_SCHIAVON_DOCUMENTS\LAVORO\GIT\BLAZOR\MS_CollectingPoints\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb7fecf9d33e0533285862e7fd5e3713d13580d6"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MS_CollectingPoints.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "D:\L_SCHIAVON_DOCUMENTS\LAVORO\GIT\BLAZOR\MS_CollectingPoints\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
