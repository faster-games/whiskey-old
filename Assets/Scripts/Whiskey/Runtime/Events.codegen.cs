﻿// <auto-generated>
// This code was generated by a tool. Any changes made manually will be lost
// the next time this code is regenerated.
// </auto-generated>

using System.Collections.Generic;
using UnityEngine;

namespace Unity3D.Whiskey
{
    /// <summary>
    /// Event that can be subscribed to, and raised.
    /// </summary>
    public interface IEvent<TArg0>
    {
        /// <summary>
        /// Subscribes a listener to the event.
        /// </summary>
        /// <param name="listener">Listener to subscribe</param>
        void Subscribe(Listener<TArg0> listener);

        /// <summary>
        /// Unsubscribes a listener from the event.
        /// </summary>
        /// <param name="listener">Listener to unsubscribe</param>
        void Unsubscribe(Listener<TArg0> listener);

        /// <summary>
        /// Raises the event.
        /// </summary>
        void Raise(TArg0 arg0);
    }

    /// <summary>
    /// Event that can be subscribed to, and raised.
    /// </summary>
    public class Event<TArg0> : ScriptableObject, IEvent<TArg0>
    {
        private readonly List<Listener<TArg0>> listeners = new List<Listener<TArg0>>();

        /// <inheritdoc />
        public void Subscribe(Listener<TArg0> listener) => listeners.Add(listener);

        /// <inheritdoc />
        public void Unsubscribe(Listener<TArg0> listener) => listeners.Remove(listener);

        /// <inheritdoc />
        public void Raise(TArg0 arg0) => listeners.ForEach(l => l.Handle( arg0));
    }

    /// <summary>
    /// Event that can be subscribed to, and raised.
    /// </summary>
    public interface IEvent<TArg0, TArg1>
    {
        /// <summary>
        /// Subscribes a listener to the event.
        /// </summary>
        /// <param name="listener">Listener to subscribe</param>
        void Subscribe(Listener<TArg0, TArg1> listener);

        /// <summary>
        /// Unsubscribes a listener from the event.
        /// </summary>
        /// <param name="listener">Listener to unsubscribe</param>
        void Unsubscribe(Listener<TArg0, TArg1> listener);

        /// <summary>
        /// Raises the event.
        /// </summary>
        void Raise(TArg0 arg0, TArg1 arg1);
    }

    /// <summary>
    /// Event that can be subscribed to, and raised.
    /// </summary>
    public class Event<TArg0, TArg1> : ScriptableObject, IEvent<TArg0, TArg1>
    {
        private readonly List<Listener<TArg0, TArg1>> listeners = new List<Listener<TArg0, TArg1>>();

        /// <inheritdoc />
        public void Subscribe(Listener<TArg0, TArg1> listener) => listeners.Add(listener);

        /// <inheritdoc />
        public void Unsubscribe(Listener<TArg0, TArg1> listener) => listeners.Remove(listener);

        /// <inheritdoc />
        public void Raise(TArg0 arg0, TArg1 arg1) => listeners.ForEach(l => l.Handle( arg0,  arg1));
    }

    /// <summary>
    /// Event that can be subscribed to, and raised.
    /// </summary>
    public interface IEvent<TArg0, TArg1, TArg2>
    {
        /// <summary>
        /// Subscribes a listener to the event.
        /// </summary>
        /// <param name="listener">Listener to subscribe</param>
        void Subscribe(Listener<TArg0, TArg1, TArg2> listener);

        /// <summary>
        /// Unsubscribes a listener from the event.
        /// </summary>
        /// <param name="listener">Listener to unsubscribe</param>
        void Unsubscribe(Listener<TArg0, TArg1, TArg2> listener);

        /// <summary>
        /// Raises the event.
        /// </summary>
        void Raise(TArg0 arg0, TArg1 arg1, TArg2 arg2);
    }

    /// <summary>
    /// Event that can be subscribed to, and raised.
    /// </summary>
    public class Event<TArg0, TArg1, TArg2> : ScriptableObject, IEvent<TArg0, TArg1, TArg2>
    {
        private readonly List<Listener<TArg0, TArg1, TArg2>> listeners = new List<Listener<TArg0, TArg1, TArg2>>();

        /// <inheritdoc />
        public void Subscribe(Listener<TArg0, TArg1, TArg2> listener) => listeners.Add(listener);

        /// <inheritdoc />
        public void Unsubscribe(Listener<TArg0, TArg1, TArg2> listener) => listeners.Remove(listener);

        /// <inheritdoc />
        public void Raise(TArg0 arg0, TArg1 arg1, TArg2 arg2) => listeners.ForEach(l => l.Handle( arg0,  arg1,  arg2));
    }

    /// <summary>
    /// Event that can be subscribed to, and raised.
    /// </summary>
    public interface IEvent<TArg0, TArg1, TArg2, TArg3>
    {
        /// <summary>
        /// Subscribes a listener to the event.
        /// </summary>
        /// <param name="listener">Listener to subscribe</param>
        void Subscribe(Listener<TArg0, TArg1, TArg2, TArg3> listener);

        /// <summary>
        /// Unsubscribes a listener from the event.
        /// </summary>
        /// <param name="listener">Listener to unsubscribe</param>
        void Unsubscribe(Listener<TArg0, TArg1, TArg2, TArg3> listener);

        /// <summary>
        /// Raises the event.
        /// </summary>
        void Raise(TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3);
    }

    /// <summary>
    /// Event that can be subscribed to, and raised.
    /// </summary>
    public class Event<TArg0, TArg1, TArg2, TArg3> : ScriptableObject, IEvent<TArg0, TArg1, TArg2, TArg3>
    {
        private readonly List<Listener<TArg0, TArg1, TArg2, TArg3>> listeners = new List<Listener<TArg0, TArg1, TArg2, TArg3>>();

        /// <inheritdoc />
        public void Subscribe(Listener<TArg0, TArg1, TArg2, TArg3> listener) => listeners.Add(listener);

        /// <inheritdoc />
        public void Unsubscribe(Listener<TArg0, TArg1, TArg2, TArg3> listener) => listeners.Remove(listener);

        /// <inheritdoc />
        public void Raise(TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3) => listeners.ForEach(l => l.Handle( arg0,  arg1,  arg2,  arg3));
    }

}

