#pragma checksum "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3900d98934be254803f19dd06c17a1281a54ce78"
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
#line 3 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor"
using Controller.DM_AD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor"
using Entity.DM_AD;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/danh_muc_ad/quan")]
    public partial class R_CAD_Quan : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Hiển thị thông tin của các quận</h3>\r\n");
            __builder.AddMarkupContent(1, "<h4>Bảng thông tin các quận</h4>\r\n");
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
#line 16 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor"
                                                                 12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(12);
                    __builder3.AddAttribute(13, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 17 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor"
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
#line 19 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor"
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
#line 22 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor"
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
#line 24 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor"
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
#line 27 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor"
                                                                                    3

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutImportExcelContext) => (__builder4) => {
                        __builder4.OpenElement(30, "a");
                        __builder4.AddAttribute(31, "href", "/FileManagement/Template/Template_Quan.xlsx");
                        __builder4.AddAttribute(32, "download", "Template_Quan.xlsx");
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
#line 40 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor"
         if (p_arrQuan == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(40, "<p><em>Loading...</em></p>");
#nullable restore
#line 43 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __Blazor.Web_App_Medical.Pages.DM_AD.R_CAD_Quan.TypeInference.CreateDxDataGrid_0(__builder, 41, 42, 
#nullable restore
#line 46 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor"
                              p_arrQuan

#line default
#line hidden
#nullable disable
            , 43, 
#nullable restore
#line 46 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor"
                                                   DataGridEditMode.PopupEditForm

#line default
#line hidden
#nullable disable
            , 44, 
#nullable restore
#line 48 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor"
                                      OnRowDeleting

#line default
#line hidden
#nullable disable
            , 45, 
#nullable restore
#line 49 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor"
                                          () => OnRowStarting(null)

#line default
#line hidden
#nullable disable
            , 46, 
#nullable restore
#line 50 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor"
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
                __builder2.AddAttribute(52, "Caption", "Tên quận");
                __builder2.AddAttribute(53, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor"
                                                                 nameof(CAD_Quan.Ten_Quan)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            , 54, (context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(55);
                __builder2.AddAttribute(56, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 56 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor"
                                     p_objQuan

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 56 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor"
                                                                                          HandleValiSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((EditFormContext) => (__builder3) => {
                    __builder3.OpenComponent<DevExpress.Blazor.DxFormLayout>(59);
                    __builder3.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(61);
                        __builder4.AddAttribute(62, "Caption", "Tên quận");
                        __builder4.AddAttribute(63, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 58 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor"
                                                                                                        12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(64, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __builder5.OpenComponent<DevExpress.Blazor.DxTextBox>(65);
                            __builder5.AddAttribute(66, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 60 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor"
                                                           p_objQuan.Ten_Quan

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(67, "TextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => p_objQuan.Ten_Quan = __value, p_objQuan.Ten_Quan))));
                            __builder5.AddAttribute(68, "TextExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => p_objQuan.Ten_Quan));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(69, "\r\n                            ");
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(70);
                        __builder4.AddAttribute(71, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 63 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor"
                                                                                     12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(72, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __builder5.OpenElement(73, "div");
                            __builder5.AddAttribute(74, "class", "text-right");
                            __builder5.OpenComponent<DevExpress.Blazor.DxButton>(75);
                            __builder5.AddAttribute(76, "RenderStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DevExpress.Blazor.ButtonRenderStyle>(
#nullable restore
#line 66 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor"
                                                               ButtonRenderStyle.Link

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(77, "SubmitFormOnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 66 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor"
                                                                                                          true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(78, "Text", "Update");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(79, "\r\n                                        ");
                            __builder5.OpenComponent<DevExpress.Blazor.DxButton>(80);
                            __builder5.AddAttribute(81, "RenderStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DevExpress.Blazor.ButtonRenderStyle>(
#nullable restore
#line 67 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor"
                                                               ButtonRenderStyle.Link

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(82, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor"
                                                                                              OnCancelButtonClick

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(83, "Text", "Cancel");
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
            , 84, (__value) => {
#nullable restore
#line 47 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor"
                              _Grid_Quan = __value;

#line default
#line hidden
#nullable disable
            }
            );
#nullable restore
#line 75 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_AD\R_CAD_Quan.razor"
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CAD_Quan_Controller _db_Quan { get; set; }
    }
}
namespace __Blazor.Web_App_Medical.Pages.DM_AD.R_CAD_Quan
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