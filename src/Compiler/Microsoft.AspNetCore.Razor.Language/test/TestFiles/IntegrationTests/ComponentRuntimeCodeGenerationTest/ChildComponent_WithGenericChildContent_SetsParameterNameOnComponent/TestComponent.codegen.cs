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
    public partial class TestComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Test.MyComponent>(0);
            __builder.AddComponentParameter(1, "MyAttr", "abc");
            __builder.AddAttribute(2, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<System.String>)((item) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    Some text");
                __builder2.OpenElement(4, "some-child");
                __builder2.AddAttribute(5, "a", "1");
                __builder2.AddContent(6, 
#nullable restore
#line (3,33)-(3,56) "x:\dir\subdir\Test\TestComponent.cshtml"
item.ToLowerInvariant()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
