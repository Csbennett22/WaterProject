#pragma checksum "C:\Users\chris\Documents\IS413\WaterProject\WaterProject\WaterProject\Pages\Admin\AdminLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01bad21e04c4bdbbbfd2af7bd1e077003e53c460"
// <auto-generated/>
#pragma warning disable 1591
namespace WaterProject.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\chris\Documents\IS413\WaterProject\WaterProject\WaterProject\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\chris\Documents\IS413\WaterProject\WaterProject\WaterProject\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\chris\Documents\IS413\WaterProject\WaterProject\WaterProject\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\chris\Documents\IS413\WaterProject\WaterProject\WaterProject\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\chris\Documents\IS413\WaterProject\WaterProject\WaterProject\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\chris\Documents\IS413\WaterProject\WaterProject\WaterProject\Pages\Admin\_Imports.razor"
using WaterProject.Models;

#line default
#line hidden
#nullable disable
    public partial class AdminLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"bg-info text-white p-2\">\r\n    <span class=\"navbar-brand m-lg-2\">Water Project Administration</span>\r\n\r\n\r\n</div>\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row p-2");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-3");
            __builder.AddMarkupContent(9, "\r\n\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "d-grid gap-2");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(13);
            __builder.AddAttribute(14, "class", "btn btn-outline-primary");
            __builder.AddAttribute(15, "href", "/admin/projects");
            __builder.AddAttribute(16, "ActiveClass", "btn-primary text-white");
            __builder.AddAttribute(17, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 15 "C:\Users\chris\Documents\IS413\WaterProject\WaterProject\WaterProject\Pages\Admin\AdminLayout.razor"
                                                                                                                            NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(19, "Projects");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(21);
            __builder.AddAttribute(22, "class", "btn btn-outline-primary");
            __builder.AddAttribute(23, "href", "/admin/donations");
            __builder.AddAttribute(24, "ActiveClass", "btn-primary text-white");
            __builder.AddAttribute(25, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 16 "C:\Users\chris\Documents\IS413\WaterProject\WaterProject\WaterProject\Pages\Admin\AdminLayout.razor"
                                                                                                                             NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(27, "Donations");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col");
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.AddContent(35, 
#nullable restore
#line 21 "C:\Users\chris\Documents\IS413\WaterProject\WaterProject\WaterProject\Pages\Admin\AdminLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(36, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
