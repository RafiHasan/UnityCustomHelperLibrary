using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ScriptableSet<T> : ScriptableObject
{
    public List<T> items;

    public void Add(T t)
    {
        if (!items.Contains(t)) items.Add(t);
    }

    public void Remove(T t)
    {
        if (items.Contains(t)) items.Remove(t);
    }
}
