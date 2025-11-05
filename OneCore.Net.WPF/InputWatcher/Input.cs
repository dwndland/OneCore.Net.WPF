// -----------------------------------------------------------------------------------------------------------------
// <copyright file="Input.cs" company="dwndland">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using OneCore.Net.WIN.WinAPI;

// ReSharper disable once CheckNamespace

namespace OneCore.Net.WPF;

/// <summary>
///     The base class for the mouse or keyboard inputs used in the <see cref="IInputWatcher" />.
/// </summary>
public abstract class Input
{
    internal abstract void Handle(WH hookType, IntPtr wParam, IntPtr lParam);
}