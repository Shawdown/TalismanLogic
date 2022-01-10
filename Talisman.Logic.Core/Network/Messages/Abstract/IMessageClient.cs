namespace Talisman.Logic.Core.Network.Messages.Abstract;

/// <summary>
/// Defines properties and methods of message client classes.
/// </summary>
///
/// <typeparam name="T">Message server type.</typeparam>
public interface IMessageClient<out T> : IMessageable where T : IMessageable
{
    /// <summary>
    /// Message server this client connected to.
    /// </summary>
    T MessageServer { get; }
}