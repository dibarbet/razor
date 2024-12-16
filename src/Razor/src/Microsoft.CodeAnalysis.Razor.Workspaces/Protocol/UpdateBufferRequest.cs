﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using System.Text.Json.Serialization;

namespace Microsoft.CodeAnalysis.Razor.Protocol;

internal sealed class UpdateBufferRequest
{
    [JsonPropertyName("hostDocumentVersion")]
    public int? HostDocumentVersion { get; set; }

    [JsonPropertyName("projectKeyId")]
    public string? ProjectKeyId { get; set; }

    [JsonPropertyName("hostDocumentFilePath")]
    public string? HostDocumentFilePath { get; set; }

    [JsonPropertyName("changes")]
    public required RazorTextChange[] Changes { get; set; }

    [JsonPropertyName("previousWasEmpty")]
    public bool PreviousWasEmpty { get; set; }
}
