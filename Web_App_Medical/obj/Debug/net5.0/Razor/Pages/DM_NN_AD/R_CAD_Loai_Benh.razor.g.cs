#pragma checksum "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a6c68671bee1c22f98d5ffc6b284acd86144e93"
// <auto-generated/>
#pragma warning disable 1591
namespace Web_App_Medical.Pages.DM_NN_AD
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
#line 5 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
using Controller.DM_NN_AD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
using Entity.DM_NN_AD;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AdminLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/danh_muc_nguoi_nhiem_ad/loai_benh")]
    public partial class R_CAD_Loai_Benh : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 14 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
 if (p_strSessionValue == "")
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p>Bạn cần đăng nhập để thực hiện chức năng</p>");
#nullable restore
#line 17 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<h3>Hiển thị thông tin của các loại bệnh</h3>\r\n    ");
            __builder.AddMarkupContent(2, "<h4>Bảng thông tin các loại bệnh</h4>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-12");
            __builder.OpenComponent<DevExpress.Blazor.DxFormLayout>(7);
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<DevExpress.Blazor.DxFormLayoutGroup>(9);
                __builder2.AddAttribute(10, "Caption", "Import Excel");
                __builder2.AddAttribute(11, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
                                                                     12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(13);
                    __builder3.AddAttribute(14, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
                                                                                        6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutImportExcelContext) => (__builder4) => {
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(16);
                        __builder4.AddAttribute(17, "class", "btn btn-sm dx-btn  btn-primary");
                        __builder4.AddAttribute(18, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 28 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
                                                                                        OnInputFileChange

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(19, "id", "InputFile_Custom");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "\r\n                    ");
                    __builder3.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(21);
                    __builder3.AddAttribute(22, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 31 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
                                                                                        3

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutImportExcelContext) => (__builder4) => {
                        __builder4.OpenComponent<DevExpress.Blazor.DxButton>(24);
                        __builder4.AddAttribute(25, "Text", "Submit");
                        __builder4.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
                                                              Import_Excel

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\r\n                    ");
                    __builder3.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(28);
                    __builder3.AddAttribute(29, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 36 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
                                                                                        3

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutImportExcelContext) => (__builder4) => {
                        __builder4.OpenElement(31, "a");
                        __builder4.AddAttribute(32, "href", "/FileManagement/Template/Template_Loai_Benh.xlsx");
                        __builder4.AddAttribute(33, "download", "Template_Loai_Benh.xlsx");
                        __builder4.OpenComponent<DevExpress.Blazor.DxButton>(34);
                        __builder4.AddAttribute(35, "Text", "Download Template");
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
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "row");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "col-md-12");
#nullable restore
#line 49 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
             if (p_arrLoai_Benh == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(41, "<p><em>Loading...</em></p>");
#nullable restore
#line 52 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __Blazor.Web_App_Medical.Pages.DM_NN_AD.R_CAD_Loai_Benh.TypeInference.CreateDxDataGrid_0(__builder, 42, 43, 
#nullable restore
#line 55 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
                                  p_arrLoai_Benh

#line default
#line hidden
#nullable disable
            , 44, 
#nullable restore
#line 55 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
                                                            DataGridEditMode.PopupEditForm

#line default
#line hidden
#nullable disable
            , 45, 
#nullable restore
#line 57 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
                                          OnRowDeleting

#line default
#line hidden
#nullable disable
            , 46, 
#nullable restore
#line 58 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
                                              () => OnRowStarting(null)

#line default
#line hidden
#nullable disable
            , 47, 
#nullable restore
#line 59 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
                                            (Item) => OnRowStarting(Item)

#line default
#line hidden
#nullable disable
            , 48, (__builder2) => {
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridCommandColumn>(49);
                __builder2.AddAttribute(50, "Width", "150px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n                        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(52);
                __builder2.AddAttribute(53, "Caption", "Tên bệnh");
                __builder2.AddAttribute(54, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 62 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
                                                                     nameof(CAD_Loai_Benh.Ten_Loai_Benh)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n                        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(56);
                __builder2.AddAttribute(57, "Caption", "Mô tả");
                __builder2.AddAttribute(58, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 63 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
                                                                  nameof(CAD_Loai_Benh.Ghi_Chu)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            , 59, (context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(60);
                __builder2.AddAttribute(61, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 66 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
                                         p_objLoai_Benh

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 66 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
                                                                                                   HandleValiSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((EditFormContext) => (__builder3) => {
                    __builder3.OpenComponent<DevExpress.Blazor.DxFormLayout>(64);
                    __builder3.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(66);
                        __builder4.AddAttribute(67, "Caption", "Tên bệnh");
                        __builder4.AddAttribute(68, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 68 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
                                                                                                            12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(69, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __builder5.OpenComponent<DevExpress.Blazor.DxTextBox>(70);
                            __builder5.AddAttribute(71, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 70 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
                                                               p_objLoai_Benh.Ten_Loai_Benh

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(72, "TextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => p_objLoai_Benh.Ten_Loai_Benh = __value, p_objLoai_Benh.Ten_Loai_Benh))));
                            __builder5.AddAttribute(73, "TextExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => p_objLoai_Benh.Ten_Loai_Benh));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(74, "\r\n                                ");
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(75);
                        __builder4.AddAttribute(76, "Caption", "Mô tả");
                        __builder4.AddAttribute(77, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 73 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
                                                                                                         12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(78, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __builder5.OpenComponent<DevExpress.Blazor.DxMemo>(79);
                            __builder5.AddAttribute(80, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 75 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
                                                            p_objLoai_Benh.Ghi_Chu

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(81, "TextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => p_objLoai_Benh.Ghi_Chu = __value, p_objLoai_Benh.Ghi_Chu))));
                            __builder5.AddAttribute(82, "TextExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => p_objLoai_Benh.Ghi_Chu));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(83, "\r\n                                ");
                        __builder4.OpenComponent<DevExpress.Blazor.DxFormLayoutItem>(84);
                        __builder4.AddAttribute(85, "ColSpanMd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 78 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
                                                                                         12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(86, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((FormLayoutContext) => (__builder5) => {
                            __builder5.OpenElement(87, "div");
                            __builder5.AddAttribute(88, "class", "text-right");
                            __builder5.OpenComponent<DevExpress.Blazor.DxButton>(89);
                            __builder5.AddAttribute(90, "RenderStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DevExpress.Blazor.ButtonRenderStyle>(
#nullable restore
#line 81 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
                                                                   ButtonRenderStyle.Link

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(91, "SubmitFormOnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 81 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
                                                                                                              true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(92, "Text", "Update");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(93, "\r\n                                            ");
                            __builder5.OpenComponent<DevExpress.Blazor.DxButton>(94);
                            __builder5.AddAttribute(95, "RenderStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DevExpress.Blazor.ButtonRenderStyle>(
#nullable restore
#line 82 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
                                                                   ButtonRenderStyle.Link

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(96, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
                                                                                                  OnCancelButtonClick

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(97, "Text", "Cancel");
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
            , 98, (__value) => {
#nullable restore
#line 56 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
                                  _Grid_Loai_Benh = __value;

#line default
#line hidden
#nullable disable
            }
            );
#nullable restore
#line 90 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 93 "D:\School\Luận Văn\Project\Project_Dissertation\Web_App_Medical\Pages\DM_NN_AD\R_CAD_Loai_Benh.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService iLocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CAD_Loai_Benh_Controller _db_Loai_Benh { get; set; }
    }
}
namespace __Blazor.Web_App_Medical.Pages.DM_NN_AD.R_CAD_Loai_Benh
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