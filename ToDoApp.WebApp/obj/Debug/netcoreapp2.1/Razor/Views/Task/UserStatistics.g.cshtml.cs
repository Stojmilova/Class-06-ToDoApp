#pragma checksum "C:\Users\Stojmilova\Desktop\Homework - Class 6\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\UserStatistics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0529752b22536c981fb1c046de7a4215642ce5d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_UserStatistics), @"mvc.1.0.view", @"/Views/Task/UserStatistics.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Task/UserStatistics.cshtml", typeof(AspNetCore.Views_Task_UserStatistics))]
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
#line 1 "C:\Users\Stojmilova\Desktop\Homework - Class 6\ToDoApp.Reworked\ToDoApp.WebApp\Views\_ViewImports.cshtml"
using ToDoApp.WebApp;

#line default
#line hidden
#line 2 "C:\Users\Stojmilova\Desktop\Homework - Class 6\ToDoApp.Reworked\ToDoApp.WebApp\Views\_ViewImports.cshtml"
using ToDoApp.WebApp.Models;

#line default
#line hidden
#line 3 "C:\Users\Stojmilova\Desktop\Homework - Class 6\ToDoApp.Reworked\ToDoApp.WebApp\Views\_ViewImports.cshtml"
using ToDoApp.Domain.Models;

#line default
#line hidden
#line 4 "C:\Users\Stojmilova\Desktop\Homework - Class 6\ToDoApp.Reworked\ToDoApp.WebApp\Views\_ViewImports.cshtml"
using ToDoApp.Domain.Enums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0529752b22536c981fb1c046de7a4215642ce5d7", @"/Views/Task/UserStatistics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"598b743e2b34c8c3c99520b14e78fb6cbc082dec", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_UserStatistics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Stojmilova\Desktop\Homework - Class 6\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\UserStatistics.cshtml"
  
    ViewBag.Title = "User Statistics";

#line default
#line hidden
            BeginContext(60, 25, true);
            WriteLiteral("\r\n<h1 style=\"color:grey\">");
            EndContext();
            BeginContext(86, 13, false);
#line 6 "C:\Users\Stojmilova\Desktop\Homework - Class 6\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\UserStatistics.cshtml"
                  Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(99, 552, true);
            WriteLiteral(@"</h1>
<br />
<table style=""border:5px  double grey; width:100%; margin-bottom:10px; padding:5px"">
    <thead>
        <tr>
            <th style=""border:1px solid black"">FirstName: </th>
            <th style=""border:1px solid black"">LastName: </th>
            <th style=""border:1px solid black"">Age: </th>
            <th style=""border:1px solid black"">Average Free Time: </th>
            <th style=""border:1px solid black"">Email </th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td style=""border:1px solid black"">");
            EndContext();
            BeginContext(652, 15, false);
#line 20 "C:\Users\Stojmilova\Desktop\Homework - Class 6\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\UserStatistics.cshtml"
                                          Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(667, 56, true);
            WriteLiteral("</td>\r\n\r\n            <td style=\"border:1px solid black\">");
            EndContext();
            BeginContext(724, 14, false);
#line 22 "C:\Users\Stojmilova\Desktop\Homework - Class 6\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\UserStatistics.cshtml"
                                          Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(738, 56, true);
            WriteLiteral("</td>\r\n\r\n            <td style=\"border:1px solid black\">");
            EndContext();
            BeginContext(795, 9, false);
#line 24 "C:\Users\Stojmilova\Desktop\Homework - Class 6\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\UserStatistics.cshtml"
                                          Write(Model.Age);

#line default
#line hidden
            EndContext();
            BeginContext(804, 56, true);
            WriteLiteral("</td>\r\n\r\n            <td style=\"border:1px solid black\">");
            EndContext();
            BeginContext(861, 21, false);
#line 26 "C:\Users\Stojmilova\Desktop\Homework - Class 6\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\UserStatistics.cshtml"
                                          Write(Model.AverageFreeTime);

#line default
#line hidden
            EndContext();
            BeginContext(882, 57, true);
            WriteLiteral(" </td>\r\n\r\n            <td style=\"border:1px solid black\">");
            EndContext();
            BeginContext(940, 11, false);
#line 28 "C:\Users\Stojmilova\Desktop\Homework - Class 6\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\UserStatistics.cshtml"
                                          Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(951, 56, true);
            WriteLiteral("</td>\r\n        </tr>\r\n    </tbody>\r\n\r\n</table>\r\n<br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
