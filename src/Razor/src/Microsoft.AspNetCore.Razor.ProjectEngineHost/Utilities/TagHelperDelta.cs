﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.AspNetCore.Razor.PooledObjects;
using Microsoft.Extensions.ObjectPool;

namespace Microsoft.AspNetCore.Razor.Utilities;

internal static class TagHelperDelta
{
    private static readonly ObjectPool<HashSet<TagHelperDescriptor>> s_tagHelperSetPool
        = HashSetPool<TagHelperDescriptor>.Create(TagHelperChecksumComparer.Instance);

    /// <summary>
    ///  Compares <paramref name="first"/> and <paramref name="second"/> and returns the items in
    ///  <paramref name="second"/> that are not in <paramref name="first"/>.
    /// </summary>
    public static ImmutableArray<TagHelperDescriptor> Compute(
        ImmutableArray<Checksum> first,
        ImmutableArray<TagHelperDescriptor> second)
    {
        // If first is empty, the delta is everything in second.
        if (first.Length == 0)
        {
            return second;
        }

        // If second is empty, the result is an empty array.
        if (second.Length == 0)
        {
            return ImmutableArray<TagHelperDescriptor>.Empty;
        }

        // Fill a hash set containing all of the items in first.
        using var _ = HashSetPool<Checksum>.GetPooledObject(out var set);

        foreach (var item in first)
        {
            set.Add(item);
        }

        using var result = new PooledArrayBuilder<TagHelperDescriptor>();

        // Finally, iterate through the items in second. If an item can
        // be added to the set, it is new and should be added to the result.
        foreach (var item in second)
        {
            if (!set.Contains(item.GetChecksum()))
            {
                result.Add(item);
            }
        }

        return result.DrainToImmutable();
    }

    /// <summary>
    ///  Compares <paramref name="first"/> and <paramref name="second"/> and returns the items in
    ///  <paramref name="second"/> that are not in <paramref name="first"/>.
    /// </summary>
    public static ImmutableArray<TagHelperDescriptor> Compute(
        ImmutableArray<TagHelperDescriptor> first,
        ImmutableArray<TagHelperDescriptor> second)
    {
        // If first is empty, the delta is everything in second.
        if (first.Length == 0)
        {
            return second;
        }

        // If second is empty, the result is an empty array.
        if (second.Length == 0)
        {
            return ImmutableArray<TagHelperDescriptor>.Empty;
        }

        // Fill a hash set containing all of the items in first.
        using var _ = s_tagHelperSetPool.GetPooledObject(out var set);

        foreach (var item in first)
        {
            set.Add(item);
        }

        using var result = new PooledArrayBuilder<TagHelperDescriptor>();

        // Finally, iterate through the items in second. If an item can
        // be added to the set, it is new and should be added to the result.
        foreach (var item in second)
        {
            if (!set.Contains(item))
            {
                result.Add(item);
            }
        }

        return result.DrainToImmutable();
    }
}
