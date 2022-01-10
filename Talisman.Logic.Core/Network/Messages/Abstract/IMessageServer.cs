using System.Collections.Generic;

namespace Talisman.Logic.Core.Network.Messages.Abstract;

/// <summary>
/// Defines properties and methods of message server classes.
/// </summary>
///
/// <typeparam name="T">Message client type.</typeparam>
public interface IMessageServer<out T> where T: IMessageable
{
    /// <summary>
    /// Clients connected to this message server.
    /// </summary>
    IEnumerable<T> Clients { get; }
}