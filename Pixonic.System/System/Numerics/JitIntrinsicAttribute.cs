// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// ReSharper disable once CheckNamespace
namespace System.Numerics
{
    /// <summary>
    /// An attribute that can be attached to JIT Intrinsic methods/properties
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Property)]
    internal class JitIntrinsicAttribute : Attribute
    {
    }
}
