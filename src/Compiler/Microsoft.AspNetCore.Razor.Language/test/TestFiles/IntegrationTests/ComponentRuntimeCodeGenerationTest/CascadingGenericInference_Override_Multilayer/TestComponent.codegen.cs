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
            {
                global::__Blazor.Test.TestComponent.TypeInference.CreateTreeNode_0_CaptureParameters(
#nullable restore
#line (1,18)-(1,30) "x:\dir\subdir\Test\TestComponent.cshtml"
DateTime.Now

#line default
#line hidden
#nullable disable
                , out var __typeInferenceArg_0___arg0);
                global::__Blazor.Test.TestComponent.TypeInference.CreateTreeNode_0(__builder, 0, 1, __typeInferenceArg_0___arg0, 2, (__builder2) => {
                    {
                        global::__Blazor.Test.TestComponent.TypeInference.CreateTreeNode_1_CaptureParameters(
#nullable restore
#line (2,22)-(2,59) "x:\dir\subdir\Test\TestComponent.cshtml"
System.Threading.Thread.CurrentThread

#line default
#line hidden
#nullable disable
                        , out var __typeInferenceArg_1___arg0);
                        global::__Blazor.Test.TestComponent.TypeInference.CreateTreeNode_1(__builder2, 3, 4, __typeInferenceArg_1___arg0, 5, (__builder3) => {
                            {
                                global::__Blazor.Test.TestComponent.TypeInference.CreateTreeNode_2_CaptureParameters(__typeInferenceArg_1___arg0, out var __typeInferenceArg_2___syntheticArg0);
                                global::__Blazor.Test.TestComponent.TypeInference.CreateTreeNode_2(__builder3, 6, __typeInferenceArg_2___syntheticArg0, 7, (__builder4) => {
                                    {
                                        global::__Blazor.Test.TestComponent.TypeInference.CreateTreeNode_3_CaptureParameters(__typeInferenceArg_1___arg0, out var __typeInferenceArg_3___syntheticArg0);
                                        global::__Blazor.Test.TestComponent.TypeInference.CreateTreeNode_3(__builder4, 8, __typeInferenceArg_3___syntheticArg0);
                                        __typeInferenceArg_3___syntheticArg0 = default;
                                    }
                                }
                                );
                                __typeInferenceArg_2___syntheticArg0 = default;
                            }
                        }
                        );
                        __typeInferenceArg_1___arg0 = default;
                    }
                    __builder2.AddMarkupContent(9, "\r\n    ");
                    {
                        global::__Blazor.Test.TestComponent.TypeInference.CreateTreeNode_4_CaptureParameters(__typeInferenceArg_0___arg0, out var __typeInferenceArg_1___syntheticArg0);
                        global::__Blazor.Test.TestComponent.TypeInference.CreateTreeNode_4(__builder2, 10, __typeInferenceArg_1___syntheticArg0);
                        __typeInferenceArg_1___syntheticArg0 = default;
                    }
                }
                );
                __typeInferenceArg_0___arg0 = default;
            }
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Test.TestComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTreeNode_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TItem __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Test.TreeNode<TItem>>(seq);
        __builder.AddComponentParameter(__seq0, "Item", __arg0);
        __builder.AddComponentParameter(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }

        public static void CreateTreeNode_0_CaptureParameters<TItem>(TItem __arg0, out TItem __arg0_out)
        {
            __arg0_out = __arg0;
        }
        public static void CreateTreeNode_1<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TItem __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Test.TreeNode<TItem>>(seq);
        __builder.AddComponentParameter(__seq0, "Item", __arg0);
        __builder.AddComponentParameter(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }

        public static void CreateTreeNode_1_CaptureParameters<TItem>(TItem __arg0, out TItem __arg0_out)
        {
            __arg0_out = __arg0;
        }
        public static void CreateTreeNode_2<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, TItem __syntheticArg0, int __seq0, global::Microsoft.AspNetCore.Components.RenderFragment __arg0)
        {
        __builder.OpenComponent<global::Test.TreeNode<TItem>>(seq);
        __builder.AddComponentParameter(__seq0, "ChildContent", __arg0);
        __builder.CloseComponent();
        }

        public static void CreateTreeNode_2_CaptureParameters<TItem>(TItem __syntheticArg0, out TItem __syntheticArg0_out)
        {
            __syntheticArg0_out = __syntheticArg0;
        }
        public static void CreateTreeNode_3<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, TItem __syntheticArg0)
        {
        __builder.OpenComponent<global::Test.TreeNode<TItem>>(seq);
        __builder.CloseComponent();
        }

        public static void CreateTreeNode_3_CaptureParameters<TItem>(TItem __syntheticArg0, out TItem __syntheticArg0_out)
        {
            __syntheticArg0_out = __syntheticArg0;
        }
        public static void CreateTreeNode_4<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, TItem __syntheticArg0)
        {
        __builder.OpenComponent<global::Test.TreeNode<TItem>>(seq);
        __builder.CloseComponent();
        }

        public static void CreateTreeNode_4_CaptureParameters<TItem>(TItem __syntheticArg0, out TItem __syntheticArg0_out)
        {
            __syntheticArg0_out = __syntheticArg0;
        }
    }
}
#pragma warning restore 1591
