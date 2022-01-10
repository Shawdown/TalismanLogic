using Talisman.Logic.Core.Network.Messages.Abstract;
using Talisman.Logic.Core.Network.Messages.Implementation;

namespace Talisman.Logic.Core.Network.Messages.Requests.Implementation;

/// <summary>
/// Base class for all game protocol requests.
/// </summary>
/// 
/// <typeparam name="T">Request data type.</typeparam>
public abstract class Request<T> : BaseMessage<T> where T : RequestData
{
    /// <inheritdoc />
    public override MessageType MessageType => MessageType.Request;

    /// <inheritdoc />
    protected Request(uint id, T data) : base(id, data)
    {
    }
}