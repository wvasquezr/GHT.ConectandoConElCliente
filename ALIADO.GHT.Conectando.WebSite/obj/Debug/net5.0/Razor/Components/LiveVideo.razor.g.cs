#pragma checksum "C:\Users\J\Google Drive\4. DEV\20210405_GHT_Conectand_Cliente\ALIADO.GHT.Conectando\ALIADO.GHT.Conectando.WebSite\Components\LiveVideo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16b7e8596b81ea732a4b11bbf743e9d6824b842d"
// <auto-generated/>
#pragma warning disable 1591
namespace ALIADO.GHT.Conectando.WebSite.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\J\Google Drive\4. DEV\20210405_GHT_Conectand_Cliente\ALIADO.GHT.Conectando\ALIADO.GHT.Conectando.WebSite\Components\LiveVideo.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\J\Google Drive\4. DEV\20210405_GHT_Conectand_Cliente\ALIADO.GHT.Conectando\ALIADO.GHT.Conectando.WebSite\Components\LiveVideo.razor"
using ALIADO.GHT.Conectando.WebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\J\Google Drive\4. DEV\20210405_GHT_Conectand_Cliente\ALIADO.GHT.Conectando\ALIADO.GHT.Conectando.WebSite\Components\LiveVideo.razor"
using ALIADO.GHT.Conectando.WebSite.Services;

#line default
#line hidden
#nullable disable
    public partial class LiveVideo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Administación de video activo</h2>\r\n\r\n");
            __builder.OpenElement(1, "h1");
            __builder.AddContent(2, 
#nullable restore
#line 10 "C:\Users\J\Google Drive\4. DEV\20210405_GHT_Conectand_Cliente\ALIADO.GHT.Conectando\ALIADO.GHT.Conectando.WebSite\Components\LiveVideo.razor"
     heading

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "form");
            __builder.AddAttribute(5, "method", "post");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\J\Google Drive\4. DEV\20210405_GHT_Conectand_Cliente\ALIADO.GHT.Conectando\ALIADO.GHT.Conectando.WebSite\Components\LiveVideo.razor"
                        e => heading = "New heading!!!"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(8, "\r\n        Update heading\r\n    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n\r\n\r\n\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "form-group");
            __builder.OpenElement(12, "form");
            __builder.AddAttribute(13, "method", "post");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "text");
            __builder.AddAttribute(16, "name", "title");
            __builder.AddAttribute(17, "placeholder", "Título del video");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\J\Google Drive\4. DEV\20210405_GHT_Conectand_Cliente\ALIADO.GHT.Conectando\ALIADO.GHT.Conectando.WebSite\Components\LiveVideo.razor"
                                  newVideo.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newVideo.Title = __value, newVideo.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "text");
            __builder.AddAttribute(23, "name", "description");
            __builder.AddAttribute(24, "placeholder", "Descripción");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\J\Google Drive\4. DEV\20210405_GHT_Conectand_Cliente\ALIADO.GHT.Conectando\ALIADO.GHT.Conectando.WebSite\Components\LiveVideo.razor"
                                  newVideo.Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newVideo.Description = __value, newVideo.Description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "type", "text");
            __builder.AddAttribute(30, "name", "maker");
            __builder.AddAttribute(31, "placeholder", "Editor");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\J\Google Drive\4. DEV\20210405_GHT_Conectand_Cliente\ALIADO.GHT.Conectando\ALIADO.GHT.Conectando.WebSite\Components\LiveVideo.razor"
                                  newVideo.Maker

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newVideo.Maker = __value, newVideo.Maker));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\J\Google Drive\4. DEV\20210405_GHT_Conectand_Cliente\ALIADO.GHT.Conectando\ALIADO.GHT.Conectando.WebSite\Components\LiveVideo.razor"
                          UploadNewLiveVideo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "class", "btn btn-primary");
            __builder.AddContent(38, "Cargar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
            __builder.OpenElement(40, "div");
#nullable restore
#line 31 "C:\Users\J\Google Drive\4. DEV\20210405_GHT_Conectand_Cliente\ALIADO.GHT.Conectando\ALIADO.GHT.Conectando.WebSite\Components\LiveVideo.razor"
     foreach (var video in LiveService.GetLives())
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(41, @"<div class=""modal-dialog modal-sm""><video id=""my-player"" preload=""auto"" data-setup=""{}""><source src=""//vjs.zencdn.net/v/oceans.mp4"" type=""video/mp4"">
                <source src=""//vjs.zencdn.net/v/oceans.webm"" type=""video/webm"">
                <source src=""//vjs.zencdn.net/v/oceans.ogv"" type=""video/ogg""></video></div>
        ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "card-columns");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "card");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "card-body");
            __builder.OpenElement(48, "h5");
            __builder.AddAttribute(49, "class", "card-title");
            __builder.AddContent(50, 
#nullable restore
#line 46 "C:\Users\J\Google Drive\4. DEV\20210405_GHT_Conectand_Cliente\ALIADO.GHT.Conectando\ALIADO.GHT.Conectando.WebSite\Components\LiveVideo.razor"
                                            video.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.OpenElement(52, "ul");
            __builder.AddAttribute(53, "class", "card-body");
            __builder.OpenElement(54, "li");
            __builder.AddMarkupContent(55, "Descripción: ");
            __builder.AddContent(56, 
#nullable restore
#line 48 "C:\Users\J\Google Drive\4. DEV\20210405_GHT_Conectand_Cliente\ALIADO.GHT.Conectando\ALIADO.GHT.Conectando.WebSite\Components\LiveVideo.razor"
                                          video.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                        ");
            __builder.OpenElement(58, "li");
            __builder.AddContent(59, "Editor de video: ");
            __builder.AddContent(60, 
#nullable restore
#line 49 "C:\Users\J\Google Drive\4. DEV\20210405_GHT_Conectand_Cliente\ALIADO.GHT.Conectando\ALIADO.GHT.Conectando.WebSite\Components\LiveVideo.razor"
                                              video.Maker

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                        ");
            __builder.OpenElement(62, "li");
            __builder.AddMarkupContent(63, "Fecha de publicación: ");
            __builder.AddContent(64, 
#nullable restore
#line 50 "C:\Users\J\Google Drive\4. DEV\20210405_GHT_Conectand_Cliente\ALIADO.GHT.Conectando\ALIADO.GHT.Conectando.WebSite\Components\LiveVideo.razor"
                                                   video.Upload

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 56 "C:\Users\J\Google Drive\4. DEV\20210405_GHT_Conectand_Cliente\ALIADO.GHT.Conectando\ALIADO.GHT.Conectando.WebSite\Components\LiveVideo.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\J\Google Drive\4. DEV\20210405_GHT_Conectand_Cliente\ALIADO.GHT.Conectando\ALIADO.GHT.Conectando.WebSite\Components\LiveVideo.razor"
       

    private string heading = "Initial heading";

    Live newVideo = new Live();

    void UploadNewLiveVideo()
    {
        newVideo.Upload = DateTime.Today.ToString();
        LiveService.AddLiveVideo(newVideo);

    }



    //Live videoOnLine;

    //void GetVideoOnLine()
    //{
    //    videoOnLine = LiveService.GetLives().First();
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileLiveService LiveService { get; set; }
    }
}
#pragma warning restore 1591