namespace Talisman.Logic.Core.Network.Messages.Responses.Abstract;

/// <summary>
/// Game protocol message response codes.
/// </summary>
public enum ResponseCode
{
    /// <summary>
    /// Request was processed without errors.
    /// </summary>
    Ok,

    /// <summary>
    /// Request data is invalid.
    /// </summary>
    InvalidRequest
}