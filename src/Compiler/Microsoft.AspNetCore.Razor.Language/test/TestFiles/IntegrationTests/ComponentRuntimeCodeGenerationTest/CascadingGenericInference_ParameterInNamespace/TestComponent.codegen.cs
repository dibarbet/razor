﻿// <auto-generated/>
#pragma warning disable 1591
namespace MyApp.Components
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
            {
                global::__Blazor.MyApp.Components.TestComponent.TypeInference.CreateParentComponent_0_CaptureParameters(
#nullable restore
#line (3,29)-(3,50) "x:\dir\subdir\Test\TestComponent.cshtml"
new MyClass<string>()

#line default
#line hidden
#nullable disable
                , out var __typeInferenceArg_0___arg0);
                global::__Blazor.MyApp.Components.TestComponent.TypeInference.CreateParentComponent_0(__builder, 0, 1, __typeInferenceArg_0___arg0, 2, (__builder2) => {
                    global::__Blazor.MyApp.Components.TestComponent.TypeInference.CreateChildComponent_1(__builder2, 3, __typeInferenceArg_0___arg0);
                }
                );
                __typeInferenceArg_0___arg0 = default;
            }
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.MyApp.Components.TestComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateParentComponent_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::MyApp.MyClass<T> __arg0, int __seq1, Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MyApp.Components.ParentComponent<T>>(seq);
        __builder.AddComponentParameter(__seq0, "Parameter", __arg0);
        __builder.AddComponentParameter(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }

        public static void CreateParentComponent_0_CaptureParameters<T>(global::MyApp.MyClass<T> __arg0, out global::MyApp.MyClass<T> __arg0_out)
        {
            __arg0_out = __arg0;
        }
        public static void CreateChildComponent_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, global::MyApp.MyClass<T> __syntheticArg0)
        {
        __builder.OpenComponent<global::MyApp.Components.ChildComponent<T>>(seq);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
