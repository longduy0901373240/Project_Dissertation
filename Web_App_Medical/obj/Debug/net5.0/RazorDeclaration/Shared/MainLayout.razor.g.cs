// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Shared\MainLayout.razor"
      
    string NavMenuCssClass { get; set; }
    protected override async Task OnInitializedAsync()
    {
        await iLocalStorage.SetItemAsync("SessionValue", "");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService iLocalStorage { get; set; }
    }
}
#pragma warning restore 1591
