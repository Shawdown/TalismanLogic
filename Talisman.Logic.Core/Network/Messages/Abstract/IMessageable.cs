using System.Threading.Tasks;
using Talisman.Logic.Core.Network.Messages.Requests.Implementation;
using Talisman.Logic.Core.Network.Messages.Responses.Implementation;

namespace Talisman.Logic.Core.Network.Messages.Abstract;

/// <summary>
/// Defines properties and methods for classes that can process messages.
/// </summary>
public interface IMessageable
{
    /// <summary>
    /// Sends an async request with no response.
    /// </summary>
    /// 
    /// <typeparam name="T">Async request data type.</typeparam>
    /// 
    /// <param name="asyncRequest">Async request to send.</param>
    void SendAsync<T>(AsyncRequest<T> asyncRequest) where T : RequestData;

    /// <summary>
    /// Sends a request and gets a response.
    /// </summary>
    /// 
    /// <typeparam name="T1">Request data type.</typeparam>
    /// <typeparam name="T2">Response data type.</typeparam>
    /// 
    /// <param name="request">Request to send.</param>
    /// 
    /// <returns><see cref="Task"/> with response data.</returns>
    Task<Response<T2>> SendRequestAsync<T1, T2>(Request<T1> request) where T1 : RequestData where T2 : ResponseData;
}