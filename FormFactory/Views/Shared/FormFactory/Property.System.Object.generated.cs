﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.488
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormFactory.Views.Shared.FormFactory
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Shared\FormFactory\Property.System.Object.cshtml"
    using FormFactory;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.3.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/FormFactory/Property.System.Object.cshtml")]
    public class Property_System_Object : System.Web.Mvc.WebViewPage<PropertyVm>
    {
        public Property_System_Object()
        {
        }
        public override void Execute()
        {



            
            #line 3 "..\..\Views\Shared\FormFactory\Property.System.Object.cshtml"
 if (!Model.IsWritable)
{
            
            #line default
            #line hidden
WriteLiteral(" <span class=\"xlarge uneditable-input\">");


            
            #line 4 "..\..\Views\Shared\FormFactory\Property.System.Object.cshtml"
                                   Write(Model.Value);

            
            #line default
            #line hidden
WriteLiteral("</span> ");


            
            #line 4 "..\..\Views\Shared\FormFactory\Property.System.Object.cshtml"
                                                            }
else
{

            
            #line default
            #line hidden
WriteLiteral("    <input class=\"xlarge\" id=\"");


            
            #line 7 "..\..\Views\Shared\FormFactory\Property.System.Object.cshtml"
                         Write(Model.Id);

            
            #line default
            #line hidden
WriteLiteral("\" name=\"");


            
            #line 7 "..\..\Views\Shared\FormFactory\Property.System.Object.cshtml"
                                          Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("\" size=\"30\" type=\"text\" value=\"");


            
            #line 7 "..\..\Views\Shared\FormFactory\Property.System.Object.cshtml"
                                                                                    Write(Model.Value);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n");


            
            #line 8 "..\..\Views\Shared\FormFactory\Property.System.Object.cshtml"
}
            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591