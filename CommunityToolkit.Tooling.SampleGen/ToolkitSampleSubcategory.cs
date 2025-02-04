// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace CommunityToolkit.Tooling.SampleGen;

/// <summary>
/// The various subcategories used by samples.
/// </summary>
/// <remarks>
/// Subcategories can be used by samples across multiple categories.
/// </remarks>
public enum ToolkitSampleSubcategory : byte
{
    /// <summary>
    /// No subcategory specified.
    /// </summary>
    None,

    /// <summary>
    /// A sample that focuses on control layout.
    /// </summary>
    Layout,

    /// <summary>
    /// A sample that focuses on status and info behaviors.
    /// </summary>
    StatusAndInfo,

    /// <summary>
    /// A sample that focuses input controls.
    /// </summary>
    Input,

    /// <summary>
    /// A sample that focuses on media controls or behaviors.
    /// </summary>
    Media,

    /// <summary>
    /// A sample that focuses on general control extensions.
    /// </summary>
    Controls,

    /// <summary>
    /// A sample that focuses on markup extensions.
    /// </summary>
    Markup,

    /// <summary>
    /// Samples that focus on helping with mathmatical operations.
    /// </summary>
    Math,

    /// <summary>
    /// Samples that focus on XAML behaviors.
    /// </summary>
    Behaviors,

    /// <summary>
    /// Samples that focus on XAML converters.
    /// </summary>
    Converters,

    /// <summary>
    /// Samples that focus on XAML triggers.
    /// </summary>
    Triggers,
}

