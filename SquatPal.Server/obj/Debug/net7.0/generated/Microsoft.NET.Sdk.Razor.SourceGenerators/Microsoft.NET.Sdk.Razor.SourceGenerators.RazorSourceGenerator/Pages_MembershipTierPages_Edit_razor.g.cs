#pragma checksum "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/MembershipTierPages/Edit.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2a63d0ad74ce98c60c3f8b6e100ea183c75a2b4abc05331b69ea457ce03b8aef"
// <auto-generated/>
#pragma warning disable 1591
namespace SquatPal.Server.Pages.MembershipTierPages
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/membership/edit/{MembershipTierId:int}")]
    public partial class Edit : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text text-primary\">Update Membership Tier</h1>");
#nullable restore
#line 8 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/MembershipTierPages/Edit.razor"
 if (errorMessage != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "h5");
            __builder.AddAttribute(2, "class", "text-danger");
#nullable restore
#line (10,30)-(10,42) 24 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/MembershipTierPages/Edit.razor"
__builder.AddContent(3, errorMessage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 11 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/MembershipTierPages/Edit.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 14 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/MembershipTierPages/Edit.razor"
                      model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/MembershipTierPages/Edit.razor"
                                             HandleSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group");
                __builder2.AddMarkupContent(14, "<label>Membership Tier Level</label>\n            ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 19 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/MembershipTierPages/Edit.razor"
                                                         model.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Name = __value, model.Name))));
                __builder2.AddAttribute(19, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n        ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, "<label>Monthly Price</label>\n            ");
                global::__Blazor.SquatPal.Server.Pages.MembershipTierPages.Edit.TypeInference.CreateInputNumber_0(__builder2, 24, 25, "form-control", 26, 
#nullable restore
#line 23 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/MembershipTierPages/Edit.razor"
                                                           model.Price

#line default
#line hidden
#nullable disable
                , 27, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Price = __value, model.Price)), 28, () => model.Price);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\n        ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.AddMarkupContent(32, "<label>Membership Tier Benefits</label>\n            ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(33);
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 27 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/MembershipTierPages/Edit.razor"
                                                         model.Benefits

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Benefits = __value, model.Benefits))));
                __builder2.AddAttribute(37, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Benefits));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\n        ");
                __builder2.AddMarkupContent(39, "<div class=\"form-group\"><button type=\"submit\" class=\"btn btn-primary btn-block mt-5\">Submit</button></div>\n        ");
                __builder2.AddMarkupContent(40, "<div class=\"form-group mt-5\"><a href=\"/membership\" class=\"btn btn-secondary\">Back to Index</a></div>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 36 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/MembershipTierPages/Edit.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/MembershipTierPages/Edit.razor"
      
    [Parameter]
    public int MembershipTierId { get; set; }
    private MembershipTierEdit model = new();
    private MembershipTierDetail membershipTierDetail = new();
    private string? errorMessage;
    protected override async Task OnInitializedAsync()
    {
        membershipTierDetail = await _membershipService.GetMembershipTier(MembershipTierId);
        if (membershipTierDetail != null)
        {
            model.Name = membershipTierDetail.Name;
            model.Price = membershipTierDetail.Price;
            model.Benefits = membershipTierDetail.Benefits;
        }
    }
    public async Task HandleSubmit()
    {
        var isSuccess = await _membershipService.UpdateMembershipTier(model);
        if (isSuccess)
        {
            _navManager.NavigateTo("/membership");
        }
        else
        {
            errorMessage = "Unable to update Membership Tier. Please try again.";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMembershipTierService _membershipService { get; set; }
    }
}
namespace __Blazor.SquatPal.Server.Pages.MembershipTierPages.Edit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
