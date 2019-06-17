namespace EventSystem
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Dispatcher
    {
        Dictionary<Type, IList> _listeners = new Dictionary<Type, IList>();

        public void Subscribe<T>(EventListener<T> listener) where T : Event
        {
            var eventType = typeof(T);
            if (!_listeners.ContainsKey(eventType))
                _listeners[eventType] = new List<EventListener<T>>();

            _listeners[eventType].Add(listener);
        }

        public void Send<T>(T @event) where T : Event
        {
            var eventType = typeof(T);
            foreach (EventListener<T> func in _listeners[eventType])
                func(@event);
        }
    }
}