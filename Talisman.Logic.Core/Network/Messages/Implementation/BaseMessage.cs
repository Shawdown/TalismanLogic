using System;
using Talisman.Logic.Core.Events.Abstract;
using Talisman.Logic.Core.Network.Messages.Abstract;

namespace Talisman.Logic.Core.Network.Messages.Implementation;

/// <summary>
/// Base class for all game protocol messages.
/// </summary>
///
/// <typeparam name="T">Message data type.</typeparam>
public abstract class BaseMessage<T>
{
    /// <summary>
    /// Message ID.
    /// </summary>
    public uint Id { get; }

    /// <summary>
    /// Message type.
    /// </summary>
    public abstract MessageType MessageType { get; }

    /// <summary>
    /// Game event type.
    /// </summary>
    public abstract EventType EventType { get; }

    /// <summary>
    /// Message data.
    /// </summary>
    public T Data { get; }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// 
    /// <param name="id">Message ID.</param>
    /// <param name="data">Message data.</param>
    /// 
    /// <exception cref="ArgumentNullException"></exception>
    protected BaseMessage(uint id, T data)
    {
        Id = id;
        Data = data ?? throw new ArgumentNullException(nameof(data));
    }
}