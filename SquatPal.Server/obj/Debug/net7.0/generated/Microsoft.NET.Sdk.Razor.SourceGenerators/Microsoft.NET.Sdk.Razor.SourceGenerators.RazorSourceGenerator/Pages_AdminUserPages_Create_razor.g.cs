#pragma checksum "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/AdminUserPages/Create.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4c4bf46fccd91033b261881949c4d8ee20e6375cacce960cf740ef61cd4b265a"
// <auto-generated/>
#pragma warning disable 1591
namespace SquatPal.Server.Pages.AdminUserPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/_Imports.razor"
using SquatPal.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/_Imports.razor"
using SquatPal.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/_Imports.razor"
using SquatPal.Models.MembershipTierModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/_Imports.razor"
using SquatPal.Models.ClientModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/_Imports.razor"
using SquatPal.Models.AdminUserModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/_Imports.razor"
using SquatPal.Models.ExercisePlanModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/_Imports.razor"
using SquatPal.Services.Services.IServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/_Imports.razor"
using SquatPal.Services.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/adminUser/create")]
    public partial class Create : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text text-primary\">Create an Admin User</h1>");
#nullable restore
#line 8 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/AdminUserPages/Create.razor"
 if (errorMessage != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "h5");
            __builder.AddAttribute(2, "class", "text-danger");
#nullable restore
#line (10,30)-(10,42) 24 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/AdminUserPages/Create.razor"
__builder.AddContent(3, errorMessage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 11 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/AdminUserPages/Create.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 15 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/AdminUserPages/Create.razor"
                          model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/AdminUserPages/Create.razor"
                                                 HandleSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\n            ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationSummary>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.AddMarkupContent(16, "<label>First Name</label>\n                ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 20 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/AdminUserPages/Create.razor"
                                                             model.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.FirstName = __value, model.FirstName))));
                __builder2.AddAttribute(21, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\n            ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group");
                __builder2.AddMarkupContent(25, "<label>Last Name</label>\n                ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(26);
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 24 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/AdminUserPages/Create.razor"
                                                             model.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.LastName = __value, model.LastName))));
                __builder2.AddAttribute(30, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\n            ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group");
                __builder2.AddMarkupContent(34, "<label>Email Address</label>\n                ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(35);
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 28 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/AdminUserPages/Create.razor"
                                                             model.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Email = __value, model.Email))));
                __builder2.AddAttribute(39, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\n            ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "<label>Username</label>\n                ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "class", "form-control");
                __builder2.AddAttribute(46, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 32 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/AdminUserPages/Create.razor"
                                                             model.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Username = __value, model.Username))));
                __builder2.AddAttribute(48, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Username));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\n            ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group");
                __builder2.AddMarkupContent(52, "<label>Password</label>\n                ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(53);
                __builder2.AddAttribute(54, "class", "form-control");
                __builder2.AddAttribute(55, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 36 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/AdminUserPages/Create.razor"
                                                             model.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Password = __value, model.Password))));
                __builder2.AddAttribute(57, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Password));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\n            ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "form-group");
                __builder2.AddMarkupContent(61, "<label>Confirm Password</label>\n                ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(62);
                __builder2.AddAttribute(63, "class", "form-control");
                __builder2.AddAttribute(64, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 40 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/AdminUserPages/Create.razor"
                                                             model.ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.ConfirmPassword = __value, model.ConfirmPassword))));
                __builder2.AddAttribute(66, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.ConfirmPassword));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\n            ");
                __builder2.AddMarkupContent(68, "<button type=\"submit\" class=\"btn btn-primary btn-block mt-5\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 45 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/AdminUserPages/Create.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/AdminUserPages/Create.razor"
      
    private AdminUserCreate model = new();
    private string? errorMessage;
    public async Task HandleSubmit()
    {
        var isSuccess = await _adminService.CreateAdminUser(model);
        if (isSuccess)
        {
            _navManager.NavigateTo("/adminUser");
        }
        else
        {
            errorMessage = "Unable to create Admin User. Please try again!";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdminUserService _adminService { get; set; }
    }
}
#pragma warning restore 1591
