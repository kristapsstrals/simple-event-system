namespace EventSystem
{
    public delegate void EventListener<T>(T @event) where T : Event;
}