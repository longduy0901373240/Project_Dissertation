#pragma checksum "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da78158b923a2d84126b75f2078ee66113d593fe"
// <auto-generated/>
#pragma warning disable 1591
namespace Web_App_Medical.Pages.User
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
#nullable restore
#line 5 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
using Controller.DM_AD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
using Controller.DM_NN_AD;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/user/map")]
    public partial class R_Map : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-md-12");
            __builder.OpenComponent<DevExpress.Blazor.DxFormLayout>(4);
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(6);
                __builder2.AddAttribute(7, "Caption", "All");
                __builder2.AddAttribute(8, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                                                                   4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder3) => {
                    __Blazor.Web_App_Medical.Pages.User.R_Map.TypeInference.CreateDxCheckBox_0(__builder3, 10, 11, 
#nullable restore
#line 20 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                          p_blCheck_Box_All

#line default
#line hidden
#nullable disable
                    , 12, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 20 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                                                               (bool item) => EvenCheckBox_All(item) 

#line default
#line hidden
#nullable disable
                    ));
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(14);
                __builder2.AddAttribute(15, "Caption", "Bệnh viện");
                __builder2.AddAttribute(16, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 23 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                                                                         4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder3) => {
                    __Blazor.Web_App_Medical.Pages.User.R_Map.TypeInference.CreateDxCheckBox_1(__builder3, 18, 19, 
#nullable restore
#line 25 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                          p_blCheck_Box_Benh_Vien

#line default
#line hidden
#nullable disable
                    , 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 25 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                                                                     (bool item)=>EvenCheckBox_Benh_Vien(item)

#line default
#line hidden
#nullable disable
                    ));
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(22);
                __builder2.AddAttribute(23, "Caption", "Người nhiểm");
                __builder2.AddAttribute(24, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 28 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                                                                           4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder3) => {
                    __Blazor.Web_App_Medical.Pages.User.R_Map.TypeInference.CreateDxCheckBox_2(__builder3, 26, 27, 
#nullable restore
#line 30 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                          p_blCheck_Box_Nguoi_Nhiem

#line default
#line hidden
#nullable disable
                    , 28, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 30 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                                                                       (bool item)=>EvenCheckBox_Nguoi_Nhiem(item)

#line default
#line hidden
#nullable disable
                    ));
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n<br>\r\n");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "row");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col-md-12");
            __builder.OpenComponent<DevExpress.Blazor.DxFormLayout>(34);
            __builder.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(36);
                __builder2.AddAttribute(37, "Caption", "Vị trí bản thân");
                __builder2.AddAttribute(38, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 40 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                                                                               6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder3) => {
                    __builder3.OpenElement(40, "input");
                    __builder3.AddAttribute(41, "id", "Search_Address_User");
                    __builder3.AddAttribute(42, "class", "form-control form-control-sm dxbs-form-control text-truncate");
                    __builder3.AddAttribute(43, "autocomplete", "on");
                    __builder3.AddAttribute(44, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                                                                                                                                         p_strAddress_User

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => p_strAddress_User = __value, p_strAddress_User));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(47);
                __builder2.AddAttribute(48, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 45 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                                                     6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder3) => {
                    __builder3.OpenComponent<DevExpress.Blazor.DxButton>(50);
                    __builder3.AddAttribute(51, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                      Submit

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(52, "Text", "Submit");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n<br>\r\n");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "row");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "col-md-12");
            __builder.OpenElement(58, "p");
            __builder.AddContent(59, 
#nullable restore
#line 56 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
            p_strAddress_User

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n<br>\r\n");
            __builder.AddMarkupContent(61, "<div class=\"row\"><div class=\"col-md-12\"><div id=\"map\"></div></div></div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CAD_Nguoi_Nhiem_Benh_Controller _db_Nguoi_Nhiem_Benh { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CAD_Dia_Chi_Nguoi_Nhiem_Benh_Controller _db_Dia_Chi_Nguoi_Nhiem_Benh { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CAD_Dia_Chi_Benh_Vien_Controller _db_Dia_Chi_Benh_Vien { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CAD_Dia_Chi_Controller _db_Dia_Chi { get; set; }
    }
}
namespace __Blazor.Web_App_Medical.Pages.User.R_Map
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateDxCheckBox_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg1)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxCheckBox<T>>(seq);
        __builder.AddAttribute(__seq0, "Checked", __arg0);
        __builder.AddAttribute(__seq1, "CheckedChanged", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateDxCheckBox_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg1)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxCheckBox<T>>(seq);
        __builder.AddAttribute(__seq0, "Checked", __arg0);
        __builder.AddAttribute(__seq1, "CheckedChanged", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateDxCheckBox_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg1)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxCheckBox<T>>(seq);
        __builder.AddAttribute(__seq0, "Checked", __arg0);
        __builder.AddAttribute(__seq1, "CheckedChanged", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591