using System.Collections.Generic;
using FasterGames.Whiskey;
using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class UnitTests
    {
        [Test]
        public void Derivation()
        {
            var mock = new GameObject("mock");
            var listener = mock.AddComponent<StringListener>();

            Assert.IsInstanceOf<MonoBehaviour>(listener);
            Assert.IsInstanceOf<ScriptableObject>(ScriptableObject.CreateInstance<StringEvent>());
        }

        [Test]
        public void Trigger_Success()
        {
            var mock = new GameObject("mock");
            var listener = mock.AddComponent<StringListener>();

            var evt = ScriptableObject.CreateInstance<StringEvent>();
            evt.Subscribe(listener);

            string expectedData = "hello world";
            string actualData = null;
            listener.Reaction.AddListener((string data) =>
            {
                actualData = data;
            });

            evt.Trigger(expectedData);

            Assert.AreEqual(expectedData, actualData);
        }

        [Test]
        public void AutoSubscribe_Success()
        {
            var mock = new GameObject("mock");
            var listener = mock.AddComponent<StringListener>();
            var evt = ScriptableObject.CreateInstance<StringEvent>();
            
            listener.Event = evt;

            // we reflect to get these, just like the UnityRuntime would for us.
            // a caller should never need to do this, but we want to force unity runtime hooks for testing.
            var OnEnable = typeof(StringListener).GetMethod("OnEnable", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            var OnDisable = typeof(StringListener).GetMethod("OnDisable", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);

            string expectedData = "hello world";
            List<string> actualData = new List<string>();
            listener.Reaction.AddListener((string data) =>
            {
                actualData.Add(data);
            });

            OnEnable.Invoke(listener, new object[0]);

            evt.Trigger(expectedData);

            OnDisable.Invoke(listener, new object[0]);

            evt.Trigger(expectedData);

            Assert.AreEqual(1, actualData.Count);
            Assert.AreEqual(expectedData, actualData[0]);
        }
    }
}
