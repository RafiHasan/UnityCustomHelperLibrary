using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ScriptableEvent : ScriptableObject
{
    private List<ScriptableEventListener> listeners = new List<ScriptableEventListener>();

    public void Raise()
    {
        for(int i= listeners.Count-1; i>=0;i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(ScriptableEventListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(ScriptableEventListener listener)
    {
        listeners.Remove(listener);
    }
}
