﻿// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line (1,2)-(2,1) "x:\dir\subdir\Test\TestComponent.cshtml"
using Microsoft.AspNetCore.Components.Web

#line default
#line hidden
#nullable disable
    ;
    public partial class TestComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "input");
            __builder.AddAttribute(1, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line (2,16)-(2,27) "x:\dir\subdir\Test\TestComponent.cshtml"
CurrentDate

#line default
#line hidden
#nullable disable
            , format: "MM/dd"));
            __builder.AddAttribute(2, "oninput", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CurrentDate = __value, CurrentDate, format: "MM/dd"));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line (3,8)-(5,1) "x:\dir\subdir\Test\TestComponent.cshtml"

    public DateTime CurrentDate { get; set; } = new DateTime(2018, 1, 1);

#line default
#line hidden
#nullable disable

    }
}
#pragma warning restore 1591
