// -----------------------------------------------------------------------------------------------------------------
// <copyright file="Callback.cs" company="dwndland">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace OneCore.Net.WPF;

internal class Callback
{
    internal Callback(int? listenMessageId, Action<NotifyEventArgs> callback)
    {
        Action = callback;
        ListenMessageId = listenMessageId;
    }

    internal Action<NotifyEventArgs> Action { get; }

    internal int? ListenMessageId { get; }
}