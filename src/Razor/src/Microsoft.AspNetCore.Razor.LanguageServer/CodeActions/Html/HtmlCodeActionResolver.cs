﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Razor.LanguageServer.CodeActions;

internal abstract class HtmlCodeActionResolver : BaseDelegatedCodeActionResolver
{
    public HtmlCodeActionResolver(IClientConnection languageServer)
        : base(languageServer)
    {
    }
}
