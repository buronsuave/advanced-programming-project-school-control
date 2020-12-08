#pragma checksum "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\admin_home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80ebf4276ee00305b46424c1d33a3a94ce4325af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.pages_admin_home), @"mvc.1.0.razor-page", @"/pages/admin_home.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80ebf4276ee00305b46424c1d33a3a94ce4325af", @"/pages/admin_home.cshtml")]
    public class pages_admin_home : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\admin_home.cshtml"
  
  Layout = "shared/_AdminMenuLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""jumbotron"">
  <h1 class=""display-3"">Welcome to School System</h1>
  <p class=""lead"">We are glad for your visit</p>
    <hr/>


    <div class=""container-fluid"">
      
      <!-- Search Content -->  
      <p class=""lead"">Check the info about one of these topics</p>
      <div class=""row"">
        <div class=""col"">
          <div class=""card bg-secondary"">
            <div class=""card-body"">
              <h5 class=""card-title"">Assignatures</h5>
              <a class=""btn btn-primary"" href=""search/assignatures"">View</a>
            </div>
          </div>
        </div>

        <div class=""col"">
          <div class=""card bg-secondary"">
            <div class=""card-body"">
              <h5 class=""card-title"">Groups</h5>
              <a class=""btn btn-primary"" href=""search/groups"">View</a>
            </div>
          </div>
        </div>

        <div class=""col"">
          <div class=""card bg-secondary"">
            <div class=""card-body"">
              <h5 c");
            WriteLiteral(@"lass=""card-title"">Teachers</h5>
              <a class=""btn btn-primary"" href=""search/teachers"">View</a>
            </div>
          </div>
        </div>

        <div class=""col"">
          <div class=""card bg-secondary"">
            <div class=""card-body"">
              <h5 class=""card-title"">Subjects</h5>
              <a class=""btn btn-primary"" href=""search/subjects"">View</a>
            </div>
          </div>
        </div>
      </div>
      <br><br><br>

      <!-- Adding Content -->  
      <p class=""lead"">Add more info to the system</p>
      <div class=""row"">
        
        <div class=""col"">
          <div class=""card bg-secondary"">
            <div class=""card-body"">
              <h5 class=""card-title"">Subjects to Group</h5>
              <a class=""btn btn-success"" href=""form/add_group_subject"">Add</a>
            </div>
          </div>
        </div>

        <div class=""col"">
          <div class=""card bg-secondary"">
            <div class=""card-body"">
    ");
            WriteLiteral(@"          <h5 class=""card-title"">Subjects to Teacher</h5>
              <a class=""btn btn-success"" href=""form/add_teacher_subject"">Add</a>
            </div>
          </div>
        </div>
        <div class=""col"">
          <div class=""card bg-secondary"">
            <div class=""card-body"">
              <h5 class=""card-title"">Group</h5>
              <a class=""btn btn-success"" href=""form/add_group"">Add</a>
            </div>
          </div>
        </div>

        <div class=""col"">
          <div class=""card bg-secondary"">
            <div class=""card-body"">
              <h5 class=""card-title"">Teacher</h5>
              <a class=""btn btn-success"" href=""form/add_teacher"">Add</a>
            </div>
          </div>
        </div>

        <div class=""col"">
          <div class=""card bg-secondary"">
            <div class=""card-body"">
              <h5 class=""card-title"">Subject</h5>
              <a class=""btn btn-success"" href=""form/add_subject"">Add</a>
            </div>
     ");
            WriteLiteral("     </div>\r\n        </div>\r\n      </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n    ");
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Users\eilopez\Desktop\FinalProject\WebApp\pages\admin_home.cshtml"
 
  public void OnGet()
  {
    ViewData["Title"] = "ase3"; 
  }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<pages_admin_home> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<pages_admin_home> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<pages_admin_home>)PageContext?.ViewData;
        public pages_admin_home Model => ViewData.Model;
    }
}
#pragma warning restore 1591
