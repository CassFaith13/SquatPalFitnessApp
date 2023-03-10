#pragma checksum "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/ExercisePlanPages/Detail.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0929341628dd91cda1bc57a21a916f3361d775af245a8ff907e2d6a1f849e23a"
// <auto-generated/>
#pragma warning disable 1591
namespace SquatPal.Server.Pages.ExercisePlanPages
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/exercise/detail/{ExerciseId:int}")]
    public partial class Detail : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text text-primary\">Exercise Plan Details</h1>");
#nullable restore
#line 7 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/ExercisePlanPages/Detail.razor"
 if (exercisePlanDetail is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p class=\"text-warning\">There is no information.</p>");
#nullable restore
#line 10 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/ExercisePlanPages/Detail.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-header d-flex justify-content-between");
            __builder.OpenElement(8, "span");
            __builder.AddContent(9, "Exercise #");
#nullable restore
#line (16,34)-(16,63) 25 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/ExercisePlanPages/Detail.razor"
__builder.AddContent(10, exercisePlanDetail.ExerciseId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-body");
            __builder.OpenElement(14, "h4");
            __builder.AddAttribute(15, "class", "card-title");
#nullable restore
#line (19,41)-(19,64) 25 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/ExercisePlanPages/Detail.razor"
__builder.AddContent(16, exercisePlanDetail.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                ");
            __builder.OpenElement(18, "p");
            __builder.AddAttribute(19, "class", "card-title");
            __builder.AddContent(20, "Exercise Type: ");
#nullable restore
#line (20,55)-(20,86) 25 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/ExercisePlanPages/Detail.razor"
__builder.AddContent(21, exercisePlanDetail.ExerciseType);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                ");
            __builder.OpenElement(23, "p");
            __builder.AddAttribute(24, "class", "card-title");
            __builder.AddContent(25, "Muscles Activated: ");
#nullable restore
#line (21,59)-(21,94) 25 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/ExercisePlanPages/Detail.razor"
__builder.AddContent(26, exercisePlanDetail.MusclesActivated);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n        ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "d-flex justify-content-center mt-3");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "text-center justify-content-between w-25");
            __builder.OpenElement(32, "a");
            __builder.AddAttribute(33, "href", "/exercise/edit/" + (
#nullable restore
#line 26 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/ExercisePlanPages/Detail.razor"
                                         exercisePlanDetail.ExerciseId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "class", "btn btn-outline-primary");
            __builder.AddContent(35, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n                ");
            __builder.OpenElement(37, "a");
            __builder.AddAttribute(38, "href", "/exercise/delete/" + (
#nullable restore
#line 27 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/ExercisePlanPages/Detail.razor"
                                           exercisePlanDetail.ExerciseId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "class", "btn btn-outline-danger");
            __builder.AddContent(40, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/ExercisePlanPages/Detail.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "/Users/home/Documents/BlueBadgeAzure/blueBadge/SquatPal/SquatPal.Server/Pages/ExercisePlanPages/Detail.razor"
      
    [Parameter]
    public int ExerciseId { get; set; }
    public ExercisePlanDetail? exercisePlanDetail { get; set; }
    protected override async Task OnInitializedAsync()
    {
        exercisePlanDetail = await _exerciseService.GetExercisePlan(ExerciseId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IExercisePlanService _exerciseService { get; set; }
    }
}
#pragma warning restore 1591
