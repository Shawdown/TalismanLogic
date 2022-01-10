using Talisman.Logic.Core.Network.Messages.Abstract;
using Talisman.Logic.Core.Network.Messages.Responses.Abstract;

namespace Talisman.Logic.Core.Network.Messages.Responses.Implementation;

/// <summary>
/// Base class for all game response DTOs.
/// </summary>
public class ResponseData
{
    /// <summary>
    /// Response code.
    /// </summary>
    public ResponseCode ResponseCode { get; set; }
}