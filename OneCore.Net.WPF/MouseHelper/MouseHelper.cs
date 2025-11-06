// -----------------------------------------------------------------------------------------------------------------
// <copyright file="MouseHelper.cs" company="dwndland">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System.Windows;
using System.Windows.Media;
using OneCore.Net.WIN.WinAPI;
using Point = System.Windows.Point;

// ReSharper disable once CheckNamespace

namespace OneCore.Net.WPF;

/// <summary>
///     Provides access to mouse related helper methods.
/// </summary>
public static class MouseHelper
{
    /// <summary>
    ///     Checks if the mouse cursor is inside the given visual element with an optional tolerance.
    /// </summary>
    /// <param name="visual"></param>
    /// <param name="tolerance"></param>
    /// <returns>True if the mouse is really above the given visual; otherwise false.</returns>
    public static bool IsMouseInside(FrameworkElement visual, double tolerance = 1.5)
    {
        var dpi = VisualTreeHelper.GetDpi(visual);
        var topLeft = visual.PointToScreen(new Point(0, 0));
        var width = visual.ActualWidth;
        var height = visual.ActualHeight;

        User32.GetCursorPos(out var pt);

        var left = topLeft.X * dpi.DpiScaleX;
        var top = topLeft.Y * dpi.DpiScaleY;
        var right = left + width * dpi.DpiScaleX;
        var bottom = top + height * dpi.DpiScaleY;

        return pt.X >= left - tolerance &&
               pt.X <= right + tolerance &&
               pt.Y >= top - tolerance &&
               pt.Y <= bottom + tolerance;
    }
}