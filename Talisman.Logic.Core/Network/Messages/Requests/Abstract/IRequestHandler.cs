using Talisman.Logic.Core.Network.Messages.Requests.Implementation;
using Talisman.Logic.Core.Network.Messages.Responses.Implementation;

namespace Talisman.Logic.Core.Network.Messages.Requests.Abstract;

/// <summary>
/// Defines properties and methods for classes that handle requests.
/// </summary>
///
/// <typeparam name="T1">Request data type.</typeparam>
/// <typeparam name="T2">Response data type.</typeparam>
public interface IRequestHandler<in T1, out T2> where T1: RequestData where T2 : ResponseData
{
    /// <summary>
    /// Handles request.
    /// </summary>
    /// 
    /// <param name="request">Request data.</param>
    /// 
    /// <returns>Response data.</returns>
    T2 HandleRequest(T1 request);
}