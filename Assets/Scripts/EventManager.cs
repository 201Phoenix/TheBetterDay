using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    private Dictionary<EventType, List<IEventHandler>>handlers;
    

    void Start()
    {
        handlers = new Dictionary<EventType, List<IEventHandler>>();
    }

    void Update()
    {}

    public void RegisterEvent(EventType type, IEventHandler handler)
    {
        GetListFor(type).Add(handler);
    }

    public void UnregisterEvent(EventType type, IEventHandler handler)
    {
        GetListFor(type).Remove(handler);
    }

    private List<IEventHandler> GetListFor(EventType type)
    {
        if (!handlers.ContainsKey(type))
        {
            handlers.Add(type, new List<IEventHandler>());
        }
        return handlers[type];
    }

    public void FireEvent(EventType type, Object evt) {
        foreach(IEventHandler handler in GetListFor(type)) {
            handler.HandleEvent(type, evt);
        }
    }
}
