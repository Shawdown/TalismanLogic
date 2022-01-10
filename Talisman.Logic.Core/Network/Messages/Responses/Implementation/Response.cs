using Talisman.Logic.Core.Network.Messages.Abstract;
using Talisman.Logic.Core.Network.Messages.Implementation;

namespace Talisman.Logic.Core.Network.Messages.Responses.Implementation;

/// <summary>
/// Base class for all game protocol responses.
/// </summary>
/// 
/// <typeparam name="T">Response data type.</typeparam>
public abstract class Response<T> : BaseMessage<T> where T : ResponseData
{
    /// <inheritdoc />
    public override MessageType MessageType => MessageType.Response;

    /// <inheritdoc />
    protected Response(uint id, T data) : base(id, data)
    {
    }
}