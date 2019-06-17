namespace EventSystem
{
    public interface IDispatcher
    {
        void Subscribe<T>(EventListener<T> listener) where T : Event;
        void Send<T>(T @event) where T : Event;
    }
}