#pragma checksum "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccc7e371d0c4227311bbe25c0e229d93fde442de"
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
#line 3 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
using Controller.DM_AD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
using Entity.DM_AD;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/danh_muc_ad/Khoa_Kham")]
    public partial class R_CAD_Khoa_Kham : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Hiển thị thông tin của các khoa khám</h3>\r\n");
            __builder.AddMarkupContent(1, "<h4>Bảng thông tin các khoa khám</h4>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-12");
            __builder.OpenComponent<DevExpress.Blazor.DxFormLayout>(6);
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<DevExpress.Blazor.DxFormLayoutGroup>(8);
                __builder2.AddAttribute(9, "Caption", "Import Excel");
                __builder2.AddAttribute(10, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
                                                                 12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(12);
                    __builder3.AddAttribute(13, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 17 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
                                                                                    6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutImportExcelContext) => (__builder4) => {
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(15);
                        __builder4.AddAttribute(16, "class", "btn btn-sm dx-btn  btn-primary");
                        __builder4.AddAttribute(17, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 19 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
                                                                                    OnInputFileChange

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(18, "id", "InputFile_Custom");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(19, "\r\n                ");
                    __builder3.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(20);
                    __builder3.AddAttribute(21, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 22 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
                                                                                    3

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutImportExcelContext) => (__builder4) => {
                        __builder4.OpenComponent<DevExpress.Blazor.DxButton>(23);
                        __builder4.AddAttribute(24, "Text", "Submit");
                        __builder4.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
                                                          Import_Excel

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\r\n                ");
                    __builder3.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(27);
                    __builder3.AddAttribute(28, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 27 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
                                                                                    3

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutImportExcelContext) => (__builder4) => {
                        __builder4.OpenElement(30, "a");
                        __builder4.AddAttribute(31, "href", "/FileManagement/Template/Template_Khoa_Kham.xlsx");
                        __builder4.AddAttribute(32, "download", "Template_Khoa_Kham.xlsx");
                        __builder4.OpenComponent<DevExpress.Blazor.DxButton>(33);
                        __builder4.AddAttribute(34, "Text", "Download Template");
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "row");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "col-md-12");
#nullable restore
#line 40 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
         if (p_arrKhoa_Kham == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(40, "<p><em>Loading...</em></p>");
#nullable restore
#line 43 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __Blazor.Web_App_Medical.Pages.DM_AD.R_CAD_Khoa_Kham.TypeInference.CreateDxDataGrid_0(__builder, 41, 42, 
#nullable restore
#line 46 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
                              p_arrKhoa_Kham

#line default
#line hidden
#nullable disable
            , 43, 
#nullable restore
#line 46 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
                                                        DataGridEditMode.PopupEditForm

#line default
#line hidden
#nullable disable
            , 44, 
#nullable restore
#line 48 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
                                      OnRowDeleting

#line default
#line hidden
#nullable disable
            , 45, 
#nullable restore
#line 49 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
                                          () => OnRowStarting(null)

#line default
#line hidden
#nullable disable
            , 46, 
#nullable restore
#line 50 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
                                        (Item) => OnRowStarting(Item)

#line default
#line hidden
#nullable disable
            , 47, (__builder2) => {
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridCommandColumn>(48);
                __builder2.AddAttribute(49, "Width", "150px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n                    ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(51);
                __builder2.AddAttribute(52, "Caption", "Tên khoa khám");
                __builder2.AddAttribute(53, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
                                                                      nameof(CAD_Khoa_Kham.Ten_Khoa_Kham)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(55);
                __builder2.AddAttribute(56, "Caption", "Mô tả");
                __builder2.AddAttribute(57, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 54 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
                                                              nameof(CAD_Khoa_Kham.Mo_Ta)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            , 58, (context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(59);
                __builder2.AddAttribute(60, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 57 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
                                     p_objKhoa_Kham

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 57 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
                                                                                               HandleValiSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((EditFormContext) => (__builder3) => {
                    __builder3.OpenComponent<DevExpress.Blazor.DxFormLayout>(63);
                    __builder3.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(65);
                        __builder4.AddAttribute(66, "Caption", "Tên khoa khám");
                        __builder4.AddAttribute(67, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 59 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
                                                                                                             12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(68, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __builder5.OpenComponent<DevExpress.Blazor.DxTextBox>(69);
                            __builder5.AddAttribute(70, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 61 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
                                                           p_objKhoa_Kham.Ten_Khoa_Kham

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(71, "TextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => p_objKhoa_Kham.Ten_Khoa_Kham = __value, p_objKhoa_Kham.Ten_Khoa_Kham))));
                            __builder5.AddAttribute(72, "TextExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => p_objKhoa_Kham.Ten_Khoa_Kham));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(73, "\r\n                            ");
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(74);
                        __builder4.AddAttribute(75, "Caption", "Mô tả");
                        __builder4.AddAttribute(76, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 64 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
                                                                                                     12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(77, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __builder5.OpenComponent<DevExpress.Blazor.DxMemo>(78);
                            __builder5.AddAttribute(79, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 66 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
                                                        p_objKhoa_Kham.Mo_Ta

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(80, "TextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => p_objKhoa_Kham.Mo_Ta = __value, p_objKhoa_Kham.Mo_Ta))));
                            __builder5.AddAttribute(81, "TextExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => p_objKhoa_Kham.Mo_Ta));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(82, "\r\n                            ");
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(83);
                        __builder4.AddAttribute(84, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 69 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
                                                                                     12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(85, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __builder5.OpenElement(86, "div");
                            __builder5.AddAttribute(87, "class", "text-right");
                            __builder5.OpenComponent<DevExpress.Blazor.DxButton>(88);
                            __builder5.AddAttribute(89, "RenderStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DevExpress.Blazor.ButtonRenderStyle>(
#nullable restore
#line 72 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
                                                               ButtonRenderStyle.Link

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(90, "SubmitFormOnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 72 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
                                                                                                          true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(91, "Text", "Update");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(92, "\r\n                                        ");
                            __builder5.OpenComponent<DevExpress.Blazor.DxButton>(93);
                            __builder5.AddAttribute(94, "RenderStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DevExpress.Blazor.ButtonRenderStyle>(
#nullable restore
#line 73 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
                                                               ButtonRenderStyle.Link

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(95, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
                                                                                              OnCancelButtonClick

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(96, "Text", "Cancel");
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
            , 97, (__value) => {
#nullable restore
#line 47 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
                              _Grid_Khoa_Kham = __value;

#line default
#line hidden
#nullable disable
            }
            );
#nullable restore
#line 81 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Khoa_Kham.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CAD_Khoa_Kham_Controller _db_Khoa_Kham { get; set; }
    }
}
namespace __Blazor.Web_App_Medical.Pages.DM_AD.R_CAD_Khoa_Kham
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
    }
}
#pragma warning restore 1591