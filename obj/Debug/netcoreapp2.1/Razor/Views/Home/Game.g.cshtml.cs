#pragma checksum "C:\Users\joann\Desktop\Tamagotchi\Tamagotchi\Views\Home\Game.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f2688f51ca00bec05aec4f5460e10388f6b1011"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Game), @"mvc.1.0.view", @"/Views/Home/Game.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Game.cshtml", typeof(AspNetCore.Views_Home_Game))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\joann\Desktop\Tamagotchi\Tamagotchi\Views\_ViewImports.cshtml"
using Tamagotchi;

#line default
#line hidden
#line 2 "C:\Users\joann\Desktop\Tamagotchi\Tamagotchi\Views\_ViewImports.cshtml"
using Tamagotchi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f2688f51ca00bec05aec4f5460e10388f6b1011", @"/Views/Home/Game.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a994ff1fc0730c5933aa46669ef685e6d3b1b38", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Game : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Grumpson>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(20, 9, true);
            WriteLiteral("<p>Name: ");
            EndContext();
            BeginContext(30, 10, false);
#line 3 "C:\Users\joann\Desktop\Tamagotchi\Tamagotchi\Views\Home\Game.cshtml"
    Write(Model.name);

#line default
#line hidden
            EndContext();
            BeginContext(40, 429, true);
            WriteLiteral(@"</p>


<div class=""center"">
<div class=""buttons"">
        <a href=""/feed""><button class=""btn btn-danger btn-xs"">Feed</button></a>
        <a href=""/rest""><button class=""btn btn-warning btn-xs"">Rest</button></a>
        <a href=""/pet""><button class=""btn btn-info btn-xs"">Pet</button></a>
        <a href=""/toy""><button class=""btn btn-success btn-xs"">Toy</button></a>
</div>
<br>
<br>

<div class=""grumpson"">
    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 469, "\"", 494, 2);
            WriteAttributeValue("", 475, "images/", 475, 7, true);
#line 17 "C:\Users\joann\Desktop\Tamagotchi\Tamagotchi\Views\Home\Game.cshtml"
WriteAttributeValue("", 482, Model.image, 482, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(495, 126, true);
            WriteLiteral(" alt=\"Grumpson\"></div>\r\n<br><br>\r\n\r\n<div class=\"bars\">\r\n    <div class=\"one\">\r\n        <div class=\"databar\">\r\n            <div");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 621, "\"", 651, 3);
            WriteAttributeValue("", 629, "width:", 629, 6, true);
#line 23 "C:\Users\joann\Desktop\Tamagotchi\Tamagotchi\Views\Home\Game.cshtml"
WriteAttributeValue(" ", 635, Model.hunger, 636, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 649, "%;", 649, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("valuenow", "\r\n                valuenow=\"", 652, "\"", 693, 1);
#line 24 "C:\Users\joann\Desktop\Tamagotchi\Tamagotchi\Views\Home\Game.cshtml"
WriteAttributeValue("", 680, Model.hunger, 680, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(694, 153, true);
            WriteLiteral(" valuemin=\"0\" valuemax=\"100\">Hunger &nbsp</div>\r\n        </div>\r\n\r\n\r\n            <div class=\"margintop\">\r\n        <div class=\"databar\">\r\n            <div");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 847, "\"", 876, 3);
            WriteAttributeValue("", 855, "width:", 855, 6, true);
#line 30 "C:\Users\joann\Desktop\Tamagotchi\Tamagotchi\Views\Home\Game.cshtml"
WriteAttributeValue(" ", 861, Model.sleep, 862, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 874, "%;", 874, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("valuenow", "\r\n                valuenow=\"", 877, "\"", 917, 1);
#line 31 "C:\Users\joann\Desktop\Tamagotchi\Tamagotchi\Views\Home\Game.cshtml"
WriteAttributeValue("", 905, Model.sleep, 905, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(918, 164, true);
            WriteLiteral(" valuemin=\"0\" valuemax=\"100\">Sleep &nbsp</div>\r\n        </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"two\">\r\n        <div class=\"databar\">\r\n            <div");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1082, "\"", 1115, 3);
            WriteAttributeValue("", 1090, "width:", 1090, 6, true);
#line 38 "C:\Users\joann\Desktop\Tamagotchi\Tamagotchi\Views\Home\Game.cshtml"
WriteAttributeValue(" ", 1096, Model.happiness, 1097, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 1113, "%;", 1113, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("valuenow", "\r\n            valuenow=\"", 1116, "\"", 1156, 1);
#line 39 "C:\Users\joann\Desktop\Tamagotchi\Tamagotchi\Views\Home\Game.cshtml"
WriteAttributeValue("", 1140, Model.happiness, 1140, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1157, 150, true);
            WriteLiteral(" valuemin=\"0\" valuemax=\"100\">Happy &nbsp</div>\r\n        </div>\r\n\r\n            <div class=\"margintop\">\r\n        <div class=\"databar\">\r\n            <div");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1307, "\"", 1335, 3);
            WriteAttributeValue("", 1315, "width:", 1315, 6, true);
#line 44 "C:\Users\joann\Desktop\Tamagotchi\Tamagotchi\Views\Home\Game.cshtml"
WriteAttributeValue(" ", 1321, Model.play, 1322, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 1333, "%;", 1333, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("valuenow", "\r\n            valuenow=\"", 1336, "\"", 1371, 1);
#line 45 "C:\Users\joann\Desktop\Tamagotchi\Tamagotchi\Views\Home\Game.cshtml"
WriteAttributeValue("", 1360, Model.play, 1360, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1372, 139, true);
            WriteLiteral(" valuemin=\"0\" valuemax=\"100\">Play &nbsp</div>\r\n        </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n<div class=\"ms\">\r\n    <p>Message: ");
            EndContext();
            BeginContext(1512, 13, false);
#line 54 "C:\Users\joann\Desktop\Tamagotchi\Tamagotchi\Views\Home\Game.cshtml"
           Write(Model.message);

#line default
#line hidden
            EndContext();
            BeginContext(1525, 32, true);
            WriteLiteral("</p>\r\n</div>\r\n\r\n<br><br>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Grumpson> Html { get; private set; }
    }
}
#pragma warning restore 1591
