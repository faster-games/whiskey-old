using System;
using UnityEngine;
using UnityEngine.Events;

namespace Unity3D.Whiskey
{
    /// <summary>
    /// Listener for events. Binds an <see cref="Event"/> to a <see cref="UnityEvent"/>. Automatically Enabled/Disabled depending on <see cref="GameObject"/> state.
    /// </summary>
    public interface IListener
    {
        /// <summary>
        /// The bound Event
        /// </summary>
        Event Event { get; set; }

        /// <summary>
        /// The bound Reaction
        /// </summary>
        UnityEvent Reaction { get; set; }

        /// <summary>
        /// Do not use.
        /// </summary>
        /// <remarks>
        /// This method is used internally to Trigger reactions from an <see cref="Event"/>. It should not be called by a Whiskey user.
        /// </remarks>
        [Obsolete]
        void Handle();
    }

    /// <summary>
    /// Listener for events. Binds an <see cref="Event"/> to a <see cref="UnityEvent"/>. Automatically Enabled/Disabled depending on <see cref="GameObject"/> state.
    /// </summary>
    /// <remarks>
    /// Attach this to any <see cref="GameObject"/> in the Unity Editor and connect one <see cref="Event"/> to multiple Unity reactions.
    /// </remarks>
    public class Listener : MonoBehaviour, IListener
    {
        [SerializeField]
        private Event @event;

        /// <inheritdoc/>
        public Event Event { get => @event; set => @event = value; }

        [SerializeField]
        private UnityEvent reaction;

        /// <inheritdoc/>
        public UnityEvent Reaction { get => reaction; set => reaction = value; }

        /// <inheritdoc/>
        public void Handle() => Reaction.Invoke();

        private void OnEnable() => Event.Subscribe(this);

        private void OnDisable() => Event.Unsubscribe(this);
    }
}
