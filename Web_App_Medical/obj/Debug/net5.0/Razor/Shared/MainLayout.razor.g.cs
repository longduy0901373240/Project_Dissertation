#pragma checksum "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a1bdd1b96cf5ea60848fb4dbb2089eac08f619e"
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.OpenComponent<Web_App_Medical.Shared.Header>(2);
            __builder.AddAttribute(3, "StateCssClass", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Shared\MainLayout.razor"
                                  NavMenuCssClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "StateCssClassChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NavMenuCssClass = __value, NavMenuCssClass))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "sidebar" + " " + (
#nullable restore
#line 8 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Shared\MainLayout.razor"
                             NavMenuCssClass

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<Web_App_Medical.Shared.NavMenu>(10);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddContent(14, 
#nullable restore
#line 12 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Shared\MainLayout.razor"
      
    string NavMenuCssClass { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591