using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEventHandler
{
    void HandleEvent(EventType type, Object evt);
}
