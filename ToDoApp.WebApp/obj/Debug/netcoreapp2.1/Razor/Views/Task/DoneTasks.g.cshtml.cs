#pragma checksum "C:\Users\Stojmilova\Desktop\Homework - Class 6\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a267388e0c65b8ddd04046fc592997f6b3f4294"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_DoneTasks), @"mvc.1.0.view", @"/Views/Task/DoneTasks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Task/DoneTasks.cshtml", typeof(AspNetCore.Views_Task_DoneTasks))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a267388e0c65b8ddd04046fc592997f6b3f4294", @"/Views/Task/DoneTasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"598b743e2b34c8c3c99520b14e78fb6cbc082dec", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_DoneTasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Stojmilova\Desktop\Homework - Class 6\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
  
    ViewBag.Title = "DoneTasks";

#line default
#line hidden
            BeginContext(54, 26, true);
            WriteLiteral("\r\n<h1 style=\"color:green\">");
            EndContext();
            BeginContext(81, 13, false);
#line 6 "C:\Users\Stojmilova\Desktop\Homework - Class 6\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
                   Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(94, 543, true);
            WriteLiteral(@"</h1>
<br />

<table style=""border:5px  double grey; width:100%; margin-bottom:10px; padding:5px"">
    <thead>
        <tr>
            <th style=""border:1px solid black"">Title</th>
            <th style=""border:1px solid black"">Description</th>
            <th style=""border:1px solid black"">Priority </th>
            <th style=""border:1px solid black"">Status</th>
            <th style=""border:1px solid black"">TaskType</th>
            <th style=""border:1px solid black"">SubTasks</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 21 "C:\Users\Stojmilova\Desktop\Homework - Class 6\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
         foreach (var task in Model.CreatedTasks)
        {
            if (task.Status == TypeStatus.Done)
            {

#line default
#line hidden
            BeginContext(763, 77, true);
            WriteLiteral("                <tr>\r\n                    <td style=\"border:1px solid black\">");
            EndContext();
            BeginContext(841, 10, false);
#line 26 "C:\Users\Stojmilova\Desktop\Homework - Class 6\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
                                                  Write(task.Title);

#line default
#line hidden
            EndContext();
            BeginContext(851, 62, true);
            WriteLiteral("</td>\r\n                    <td style=\"border:1px solid black\">");
            EndContext();
            BeginContext(914, 16, false);
#line 27 "C:\Users\Stojmilova\Desktop\Homework - Class 6\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
                                                  Write(task.Description);

#line default
#line hidden
            EndContext();
            BeginContext(930, 62, true);
            WriteLiteral("</td>\r\n                    <td style=\"border:1px solid black\">");
            EndContext();
            BeginContext(993, 13, false);
#line 28 "C:\Users\Stojmilova\Desktop\Homework - Class 6\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
                                                  Write(task.Priority);

#line default
#line hidden
            EndContext();
            BeginContext(1006, 62, true);
            WriteLiteral("</td>\r\n                    <td style=\"border:1px solid black\">");
            EndContext();
            BeginContext(1069, 11, false);
#line 29 "C:\Users\Stojmilova\Desktop\Homework - Class 6\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
                                                  Write(task.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1080, 62, true);
            WriteLiteral("</td>\r\n                    <td style=\"border:1px solid black\">");
            EndContext();
            BeginContext(1143, 13, false);
#line 30 "C:\Users\Stojmilova\Desktop\Homework - Class 6\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
                                                  Write(task.TaskType);

#line default
#line hidden
            EndContext();
            BeginContext(1156, 94, true);
            WriteLiteral("</td>\r\n                    <td style=\"border:1px solid black\">\r\n                        <ul>\r\n");
            EndContext();
#line 33 "C:\Users\Stojmilova\Desktop\Homework - Class 6\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
                             foreach (var subTask in task.SubTasks)
                            {

#line default
#line hidden
            BeginContext(1350, 43, true);
            WriteLiteral("                                <li>Title: ");
            EndContext();
            BeginContext(1394, 13, false);
#line 35 "C:\Users\Stojmilova\Desktop\Homework - Class 6\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
                                      Write(subTask.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1407, 17, true);
            WriteLiteral(" => Description: ");
            EndContext();
            BeginContext(1425, 19, false);
#line 35 "C:\Users\Stojmilova\Desktop\Homework - Class 6\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
                                                                     Write(subTask.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1444, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 36 "C:\Users\Stojmilova\Desktop\Homework - Class 6\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
                            }

#line default
#line hidden
            BeginContext(1482, 128, true);
            WriteLiteral("                        </ul>\r\n                    </td>\r\n                    <td><button type=\"button\" class=\"btn btn-success\">");
            EndContext();
            BeginContext(1611, 76, false);
#line 39 "C:\Users\Stojmilova\Desktop\Homework - Class 6\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
                                                                 Write(Html.ActionLink("View DETAILS", "DetailsTask", "Task", new { id = task.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1687, 39, true);
            WriteLiteral("</button></td>\r\n                </tr>\r\n");
            EndContext();
#line 41 "C:\Users\Stojmilova\Desktop\Homework - Class 6\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\DoneTasks.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(1752, 26, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
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