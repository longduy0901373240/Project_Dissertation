#pragma checksum "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8554fccfea663629df93750da27e3459427b41e1"
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
#nullable restore
#line 7 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
using Controller.DM_VN_AD;

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
            __builder.AddMarkupContent(0, "<style>\r\n    #map{\r\n        height:100%;\r\n        width:100%;\r\n    }\r\n</style>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-12");
            __builder.OpenComponent<DevExpress.Blazor.DxFormLayout>(5);
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(7);
                __builder2.AddAttribute(8, "Caption", "All");
                __builder2.AddAttribute(9, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                                                                   4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder3) => {
                    __Blazor.Web_App_Medical.Pages.User.R_Map.TypeInference.CreateDxCheckBox_0(__builder3, 11, 12, 
#nullable restore
#line 28 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                          p_blCheck_Box_All

#line default
#line hidden
#nullable disable
                    , 13, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 28 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                                                               (bool item) => EvenCheckBox_All(item) 

#line default
#line hidden
#nullable disable
                    ));
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(15);
                __builder2.AddAttribute(16, "Caption", "Bệnh viện");
                __builder2.AddAttribute(17, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 31 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                                                                         4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder3) => {
                    __Blazor.Web_App_Medical.Pages.User.R_Map.TypeInference.CreateDxCheckBox_1(__builder3, 19, 20, 
#nullable restore
#line 33 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                          p_blCheck_Box_Benh_Vien

#line default
#line hidden
#nullable disable
                    , 21, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 33 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                                                                     (bool item)=>EvenCheckBox_Benh_Vien(item)

#line default
#line hidden
#nullable disable
                    ));
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(23);
                __builder2.AddAttribute(24, "Caption", "Người nhiểm");
                __builder2.AddAttribute(25, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 36 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                                                                           4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder3) => {
                    __Blazor.Web_App_Medical.Pages.User.R_Map.TypeInference.CreateDxCheckBox_2(__builder3, 27, 28, 
#nullable restore
#line 38 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                          p_blCheck_Box_Nguoi_Nhiem

#line default
#line hidden
#nullable disable
                    , 29, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 38 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                                                                       (bool item)=>EvenCheckBox_Nguoi_Nhiem(item)

#line default
#line hidden
#nullable disable
                    ));
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(31);
                __builder2.AddAttribute(32, "Caption", "Người nghi nhiểm");
                __builder2.AddAttribute(33, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 41 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                                                                                4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder3) => {
                    __Blazor.Web_App_Medical.Pages.User.R_Map.TypeInference.CreateDxCheckBox_3(__builder3, 35, 36, 
#nullable restore
#line 43 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                          p_blCheck_Box_Nguoi_Nghi_Nhiem

#line default
#line hidden
#nullable disable
                    , 37, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 43 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                                                                            (bool item)=>EvenCheckBox_Nguoi_Nghi_Nhiem(item)

#line default
#line hidden
#nullable disable
                    ));
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(39);
                __builder2.AddAttribute(40, "Caption", "Điểm nhiểm");
                __builder2.AddAttribute(41, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 46 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                                                                          4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder3) => {
                    __Blazor.Web_App_Medical.Pages.User.R_Map.TypeInference.CreateDxCheckBox_4(__builder3, 43, 44, 
#nullable restore
#line 48 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                          p_blCheck_Box_Diem_Cach_Ly

#line default
#line hidden
#nullable disable
                    , 45, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 48 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                                                                        (bool item)=>EvenCheckBox_Diem_Cach_Ly(item)

#line default
#line hidden
#nullable disable
                    ));
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(47);
                __builder2.AddAttribute(48, "Caption", "Vùng nhiểm");
                __builder2.AddAttribute(49, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 51 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                                                                          4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder3) => {
                    __Blazor.Web_App_Medical.Pages.User.R_Map.TypeInference.CreateDxCheckBox_5(__builder3, 51, 52, 
#nullable restore
#line 53 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                          p_blCheck_Box_Vung_Cach_Ly

#line default
#line hidden
#nullable disable
                    , 53, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 53 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                                                                        (bool item)=>EvenCheckBox_Vung_Cach_Ly(item)

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
            __builder.AddMarkupContent(54, "\r\n<br>\r\n");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "row");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "col-md-12");
            __builder.OpenComponent<DevExpress.Blazor.DxFormLayout>(59);
            __builder.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(61);
                __builder2.AddAttribute(62, "Caption", "Vị trí bản thân");
                __builder2.AddAttribute(63, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 63 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                                                                               6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder3) => {
                    __builder3.OpenElement(65, "input");
                    __builder3.AddAttribute(66, "id", "Search_Address_User");
                    __builder3.AddAttribute(67, "class", "form-control form-control-sm dxbs-form-control text-truncate");
                    __builder3.AddAttribute(68, "autocomplete", "on");
                    __builder3.AddAttribute(69, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 65 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                                                                                                                                         p_strAddress_User

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => p_strAddress_User = __value, p_strAddress_User));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n            ");
                __builder2.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(72);
                __builder2.AddAttribute(73, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 68 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                                                     6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder3) => {
                    __builder3.OpenComponent<DevExpress.Blazor.DxButton>(75);
                    __builder3.AddAttribute(76, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\User\R_Map.razor"
                                      Submit

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(77, "Text", "Submit");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n<br>\r\n<div id=\"map\" class=\"mw-100\"></div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CAD_Vung_Cach_Ly_Controller _db_Vung_Cach_Ly { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CAD_Diem_Cach_Ly_Controller _db_Diem_Cach_Ly { get; set; }
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
        public static void CreateDxCheckBox_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg1)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxCheckBox<T>>(seq);
        __builder.AddAttribute(__seq0, "Checked", __arg0);
        __builder.AddAttribute(__seq1, "CheckedChanged", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateDxCheckBox_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg1)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxCheckBox<T>>(seq);
        __builder.AddAttribute(__seq0, "Checked", __arg0);
        __builder.AddAttribute(__seq1, "CheckedChanged", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateDxCheckBox_5<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg1)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxCheckBox<T>>(seq);
        __builder.AddAttribute(__seq0, "Checked", __arg0);
        __builder.AddAttribute(__seq1, "CheckedChanged", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
