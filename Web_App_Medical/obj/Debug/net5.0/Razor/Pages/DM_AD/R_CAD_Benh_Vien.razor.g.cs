#pragma checksum "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d57565e309cf7e05ae3b7918ff9f7c2a3fd3558f"
// <auto-generated/>
#pragma warning disable 1591
namespace Web_App_Medical.Pages.DM_AD
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
#line 3 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
using Controller.DM_AD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
using Entity.DM_AD;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/danh_muc_ad/benh_vien")]
    public partial class R_CAD_Benh_Vien : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Hiển thị thông tin của các bệnh viện</h3>\r\n");
            __builder.AddMarkupContent(1, "<h4>Bảng thông tin các bệnh viện</h4>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-12");
#nullable restore
#line 15 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
         if (p_arrBenh_Vien == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p><em>Loading...</em></p>");
#nullable restore
#line 18 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __Blazor.Web_App_Medical.Pages.DM_AD.R_CAD_Benh_Vien.TypeInference.CreateDxDataGrid_0(__builder, 7, 8, 
#nullable restore
#line 21 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                              p_arrBenh_Vien

#line default
#line hidden
#nullable disable
            , 9, 
#nullable restore
#line 21 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                                        DataGridEditMode.PopupEditForm

#line default
#line hidden
#nullable disable
            , 10, 
#nullable restore
#line 23 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                      OnRowDeleting

#line default
#line hidden
#nullable disable
            , 11, 
#nullable restore
#line 24 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                          () => OnRowStarting(null)

#line default
#line hidden
#nullable disable
            , 12, 
#nullable restore
#line 25 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                        (Item) => OnRowStarting(Item)

#line default
#line hidden
#nullable disable
            , 13, (__builder2) => {
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridCommandColumn>(14);
                __builder2.AddAttribute(15, "Width", "150px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n                    ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(17);
                __builder2.AddAttribute(18, "Caption", "Tên bệnh viện");
                __builder2.AddAttribute(19, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                                                      nameof(CAD_Benh_Vien.Ten_Benh_Vien)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n                    ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(21);
                __builder2.AddAttribute(22, "Caption", "SĐT");
                __builder2.AddAttribute(23, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                                            nameof(CAD_Benh_Vien.SDT)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n                    ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(25);
                __builder2.AddAttribute(26, "Caption", "Email");
                __builder2.AddAttribute(27, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                                              nameof(CAD_Benh_Vien.Email)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n                    ");
                __Blazor.Web_App_Medical.Pages.DM_AD.R_CAD_Benh_Vien.TypeInference.CreateDxDataGridComboBoxColumn_1(__builder2, 29, 30, "Chuyện khoa", 31, 
#nullable restore
#line 31 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                                                            nameof(CAD_Benh_Vien.Chuyen_Khoa)

#line default
#line hidden
#nullable disable
                , 32, 
#nullable restore
#line 32 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                      p_arrKhoa_Kham

#line default
#line hidden
#nullable disable
                , 33, 
#nullable restore
#line 32 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                                                       nameof(CAD_Khoa_Kham.Auto_ID)

#line default
#line hidden
#nullable disable
                , 34, 
#nullable restore
#line 32 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                                                                                                      nameof(CAD_Khoa_Kham.Ten_Khoa_Kham)

#line default
#line hidden
#nullable disable
                );
            }
            , 35, (context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(36);
                __builder2.AddAttribute(37, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 35 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                     p_objBenh_Vien

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 35 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                                                                               HandleValiSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((EditFormContext) => (__builder3) => {
                    __builder3.OpenComponent<DevExpress.Blazor.DxFormLayout>(40);
                    __builder3.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(42);
                        __builder4.AddAttribute(43, "Caption", "Tên bệnh viện");
                        __builder4.AddAttribute(44, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 37 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                                                                                             12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(45, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __builder5.OpenComponent<DevExpress.Blazor.DxTextBox>(46);
                            __builder5.AddAttribute(47, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                                           p_objBenh_Vien.Ten_Benh_Vien

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(48, "TextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => p_objBenh_Vien.Ten_Benh_Vien = __value, p_objBenh_Vien.Ten_Benh_Vien))));
                            __builder5.AddAttribute(49, "TextExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => p_objBenh_Vien.Ten_Benh_Vien));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(50, "\r\n                            ");
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(51);
                        __builder4.AddAttribute(52, "Caption", "Số điện thoại");
                        __builder4.AddAttribute(53, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 42 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                                                                                             12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(54, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __builder5.OpenComponent<DevExpress.Blazor.DxTextBox>(55);
                            __builder5.AddAttribute(56, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                                           p_objBenh_Vien.SDT

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(57, "TextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => p_objBenh_Vien.SDT = __value, p_objBenh_Vien.SDT))));
                            __builder5.AddAttribute(58, "TextExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => p_objBenh_Vien.SDT));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(59, "\r\n                            ");
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(60);
                        __builder4.AddAttribute(61, "Caption", "Email");
                        __builder4.AddAttribute(62, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 47 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                                                                                     12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(63, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __builder5.OpenComponent<DevExpress.Blazor.DxTextBox>(64);
                            __builder5.AddAttribute(65, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 49 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                                           p_objBenh_Vien.Email

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(66, "TextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => p_objBenh_Vien.Email = __value, p_objBenh_Vien.Email))));
                            __builder5.AddAttribute(67, "TextExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => p_objBenh_Vien.Email));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(68, "\r\n                            ");
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(69);
                        __builder4.AddAttribute(70, "Caption", "Chuyên khoa");
                        __builder4.AddAttribute(71, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 52 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                                                                                           12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(72, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __Blazor.Web_App_Medical.Pages.DM_AD.R_CAD_Benh_Vien.TypeInference.CreateDxComboBox_2(__builder5, 73, 74, 
#nullable restore
#line 54 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                                                                                        DataGridFilteringMode.Contains

#line default
#line hidden
#nullable disable
                            , 75, 
#nullable restore
#line 55 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                                      p_arrKhoa_Kham

#line default
#line hidden
#nullable disable
                            , 76, "Auto_ID", 77, "Ten_Khoa_Kham", 78, 
#nullable restore
#line 54 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                                             p_objBenh_Vien.Chuyen_Khoa

#line default
#line hidden
#nullable disable
                            , 79, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => p_objBenh_Vien.Chuyen_Khoa = __value, p_objBenh_Vien.Chuyen_Khoa)), 80, () => p_objBenh_Vien.Chuyen_Khoa);
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(81, "\r\n                            ");
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(82);
                        __builder4.AddAttribute(83, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 58 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                                                                     12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(84, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __builder5.OpenElement(85, "div");
                            __builder5.AddAttribute(86, "class", "text-right");
                            __builder5.OpenComponent<DevExpress.Blazor.DxButton>(87);
                            __builder5.AddAttribute(88, "RenderStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DevExpress.Blazor.ButtonRenderStyle>(
#nullable restore
#line 61 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                                               ButtonRenderStyle.Link

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(89, "SubmitFormOnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 61 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                                                                                          true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(90, "Text", "Update");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(91, "\r\n                                        ");
                            __builder5.OpenComponent<DevExpress.Blazor.DxButton>(92);
                            __builder5.AddAttribute(93, "RenderStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DevExpress.Blazor.ButtonRenderStyle>(
#nullable restore
#line 62 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                                               ButtonRenderStyle.Link

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(94, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                                                                                              OnCancelButtonClick

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(95, "Text", "Cancel");
                            __builder5.CloseComponent();
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 96, (__value) => {
#nullable restore
#line 22 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
                              _Grid_Benh_Vien = __value;

#line default
#line hidden
#nullable disable
            }
            );
#nullable restore
#line 70 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Benh_Vien.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CAD_Khoa_Kham_Controller _db_Khoa_Kham { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CAD_Benh_Vien_Controller _db_Benh_Vien { get; set; }
    }
}
namespace __Blazor.Web_App_Medical.Pages.DM_AD.R_CAD_Benh_Vien
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateDxDataGrid_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::DevExpress.Blazor.DataGridEditMode __arg1, int __seq2, global::System.Action<T> __arg2, int __seq3, global::System.Action __arg3, int __seq4, global::System.Action<T> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg6, int __seq7, global::System.Action<global::DevExpress.Blazor.DxDataGrid<T>> __arg7)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxDataGrid<T>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "EditMode", __arg1);
        __builder.AddAttribute(__seq2, "RowRemoving", __arg2);
        __builder.AddAttribute(__seq3, "RowInsertStart", __arg3);
        __builder.AddAttribute(__seq4, "RowEditStart", __arg4);
        __builder.AddAttribute(__seq5, "Columns", __arg5);
        __builder.AddAttribute(__seq6, "EditFormTemplate", __arg6);
        __builder.AddComponentReferenceCapture(__seq7, (__value) => { __arg7((global::DevExpress.Blazor.DxDataGrid<T>)__value); });
        __builder.CloseComponent();
        }
        public static void CreateDxDataGridComboBoxColumn_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Collections.Generic.IEnumerable<T> __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxDataGridComboBoxColumn<T>>(seq);
        __builder.AddAttribute(__seq0, "Caption", __arg0);
        __builder.AddAttribute(__seq1, "Field", __arg1);
        __builder.AddAttribute(__seq2, "Data", __arg2);
        __builder.AddAttribute(__seq3, "ValueFieldName", __arg3);
        __builder.AddAttribute(__seq4, "TextFieldName", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateDxComboBox_2<TData, TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::DevExpress.Blazor.DataGridFilteringMode __arg0, int __seq1, global::System.Collections.Generic.IEnumerable<TData> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6)
        {
        __builder.OpenComponent<global::DevExpress.Blazor.DxComboBox<TData, TValue>>(seq);
        __builder.AddAttribute(__seq0, "FilteringMode", __arg0);
        __builder.AddAttribute(__seq1, "Data", __arg1);
        __builder.AddAttribute(__seq2, "ValueFieldName", __arg2);
        __builder.AddAttribute(__seq3, "TextFieldName", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591