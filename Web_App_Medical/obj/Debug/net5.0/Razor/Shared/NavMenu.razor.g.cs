#pragma checksum "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93456a08996d3acab5d7843ee168a40ff72f10dc"
// <auto-generated/>
#pragma warning disable 1591
namespace Web_App_Medical.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\_Imports.razor"
using Web_App_Medical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\_Imports.razor"
using Web_App_Medical.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\_Imports.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<DevExpress.Blazor.DxTreeView>(0);
            __builder.AddAttribute(1, "AllowSelectNodes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 1 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Shared\NavMenu.razor"
                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "CssClass", "app-sidebar");
            __builder.AddAttribute(3, "Nodes", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<DevExpress.Blazor.DxTreeViewNode>(4);
                __builder2.AddAttribute(5, "NavigateUrl", "");
                __builder2.AddAttribute(6, "Text", "Overview");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxTreeViewNode>(8);
                __builder2.AddAttribute(9, "NavigateUrl", "datagrid");
                __builder2.AddAttribute(10, "Text", "Data Grid");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxTreeViewNode>(12);
                __builder2.AddAttribute(13, "Text", "Dashboard");
                __builder2.AddAttribute(14, "Nodes", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<DevExpress.Blazor.DxTreeViewNode>(15);
                    __builder3.AddAttribute(16, "NavigateUrl", "/dashboard/map");
                    __builder3.AddAttribute(17, "Text", "Map");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\r\n                ");
                    __builder3.OpenComponent<DevExpress.Blazor.DxTreeViewNode>(19);
                    __builder3.AddAttribute(20, "NavigateUrl", "/dashboard/map_direct_benh_vien");
                    __builder3.AddAttribute(21, "Text", "Map Direct Bệnh Viện");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
