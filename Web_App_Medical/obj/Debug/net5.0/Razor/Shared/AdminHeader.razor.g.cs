#pragma checksum "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Shared\AdminHeader.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3f1fef084503ff4e357e7c7b8626bd012f85203"
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
    public partial class AdminHeader : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar header-navbar p-0");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "navbar-toggler bg-primary d-block");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Shared\AdminHeader.razor"
                                                                OnToggleClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "<span class=\"navbar-toggler-icon\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.AddMarkupContent(7, "<div class=\"ml-3 font-weight-bold title pr-4\">Web_App_Medical</div>\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-1 float-right");
            __builder.OpenComponent<DevExpress.Blazor.DxButton>(12);
            __builder.AddAttribute(13, "Text", "Sign Out");
            __builder.AddAttribute(14, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Shared\AdminHeader.razor"
                                             Event_Sign_Out

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "float-right");
            __builder.OpenElement(18, "h4");
            __builder.AddContent(19, 
#nullable restore
#line 14 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Shared\AdminHeader.razor"
                 p_strSessionValue

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Shared\AdminHeader.razor"
       
    private string p_strSessionValue = "";
    bool isDesktop = true, isToggled = true, isInitialized;

    [Parameter] public string StateCssClass { get; set; }
    [Parameter] public EventCallback<string> StateCssClassChanged { get; set; }
    protected override async Task OnInitializedAsync()
    {
        p_strSessionValue = await iLocalStorage.GetItemAsync<string>("SessionValue");
    }

    protected override void OnInitialized()
    {
        NavigationManager.LocationChanged += OnLocationChanged;
    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
            await JSRuntime.InvokeVoidAsync("windowMinWidthMatchesQuery", DotNetObjectReference.Create(this));
        isInitialized = true;
        await base.OnAfterRenderAsync(firstRender);
    }

    [JSInvokable]
    public async Task OnWindowMinWidthQueryChanged(bool matchesDesktop)
    {

        if (!isInitialized || isDesktop != matchesDesktop)
        {
            isDesktop = matchesDesktop;
            if (isInitialized || !isDesktop)
                await ToggleNavMenu(matchesDesktop);
        }
    }
    async Task OnToggleClick() => await ToggleNavMenu();

    async void OnLocationChanged(object sender, LocationChangedEventArgs args)
    {
        if (!isDesktop)
            await ToggleNavMenu(false);
    }

    async Task ToggleNavMenu(bool? value = null)
    {
        var newValue = value ?? !isToggled;
        isToggled = value ?? !isToggled;
        string stateCssClass = isToggled ? "expand" : "collapse";
        if (StateCssClass != stateCssClass)
        {
            StateCssClass = stateCssClass;
            await StateCssClassChanged.InvokeAsync(StateCssClass);
        }
    }
    public void Dispose()
    {
        NavigationManager.LocationChanged -= OnLocationChanged;
    }
    private async void Event_Sign_Out()
    {
        p_strSessionValue = "";
        await iLocalStorage.SetItemAsync("SessionValue", p_strSessionValue);
        NavigationManager.NavigateTo("/admin/sign_in");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService iLocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
