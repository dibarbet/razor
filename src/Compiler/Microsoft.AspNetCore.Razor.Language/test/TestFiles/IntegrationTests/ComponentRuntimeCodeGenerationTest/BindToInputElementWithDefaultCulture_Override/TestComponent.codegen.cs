﻿// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line (1,2)-(1,28) "x:\dir\subdir\Test\TestComponent.cshtml"
using System.Globalization

#nullable disable
    ;
    #line default
    #line hidden
    #nullable restore
    public partial class TestComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "input");
            __builder.AddAttribute(1, "type", "custom");
            __builder.AddAttribute(2, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line (2,36)-(2,47) "x:\dir\subdir\Test\TestComponent.cshtml"
ParentValue

#line default
#line hidden
#nullable disable
            , culture: 
#nullable restore
#line (2,103)-(2,129) "x:\dir\subdir\Test\TestComponent.cshtml"
CultureInfo.CurrentCulture

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "anotherevent", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ParentValue = __value, ParentValue, culture: CultureInfo.CurrentCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line (3,8)-(5,1) "x:\dir\subdir\Test\TestComponent.cshtml"

    public int ParentValue { get; set; }

#line default
#line hidden
#nullable disable

    }
}
#pragma warning restore 1591
