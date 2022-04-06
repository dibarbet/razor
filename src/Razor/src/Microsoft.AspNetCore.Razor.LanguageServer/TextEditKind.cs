// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

#nullable disable

namespace Microsoft.AspNetCore.Razor.LanguageServer
{
    internal enum TextEditKind
    {
        Default,
        FormatOnType,
        Snippet,
        /*
         TODO Rename format on type to something else
         Add new one which is format non whitespace changes.
         This should bypass validation.

         Also debug weird cancellaiton when override completion with extra whitespace on the line before
         */
    }
}
