using Talisman.Logic.Core.Network.Messages.Abstract;
using Talisman.Logic.Core.Network.Messages.Implementation;

namespace Talisman.Logic.Core.Network.Messages.Requests.Implementation;

/// <summary>
/// Base class for all async requests with no response.
/// </summary>
public abstract class AsyncRequest<T> : BaseMessage<T> where T : RequestData
{
    /// <inheritdoc />
    public override MessageType MessageType => MessageType.AsyncRequest;

    /// <inheritdoc />
    protected AsyncRequest(uint id, T data) : base(id, data)
    {
    }
}