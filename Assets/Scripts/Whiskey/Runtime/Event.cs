using System.Collections.Generic;
using UnityEngine;

namespace Unity3D.Whiskey
{
    /// <summary>
    /// Event that can be subscribed to, and raised.
    /// </summary>
    public interface IEvent
    {
        /// <summary>
        /// Subscribes a listener to the event.
        /// </summary>
        /// <param name="listener">Listener to subscribe</param>
        void Subscribe(Listener listener);

        /// <summary>
        /// Unsubscribes a listener from the event.
        /// </summary>
        /// <param name="listener">Listener to unsubscribe</param>
        void Unsubscribe(Listener listener);

        /// <summary>
        /// Raises the event.
        /// </summary>
        void Raise();
    }

    /// <summary>
    /// Event that can be subscribed to, and raised.
    /// </summary>
    /// <remarks>
    /// Create a new String in the Unity Editor project pane with "Right Click => Whiskey => Events => Void".
    /// </remarks>
    [CreateAssetMenu(menuName = "Whiskey/Events/Void")]
    public class Event : ScriptableObject, IEvent
    {
        private readonly List<Listener> listeners = new List<Listener>();

        /// <inheritdoc />
        public void Subscribe(Listener listener) => listeners.Add(listener);

        /// <inheritdoc />
        public void Unsubscribe(Listener listener) => listeners.Remove(listener);

        /// <inheritdoc />
        public void Raise() => listeners.ForEach(l => l.Handle());
    }
}
