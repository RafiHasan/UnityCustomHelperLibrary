using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractVariable<T> : ScriptableObject
{
    public T value;
}
public abstract class AbstractRefarance<T>
{
    public bool UseConstant = true;
    public T ConstantValue;
    public AbstractVariable<T> Variable;

    public T Value
    {
        get
        {
            return UseConstant ? ConstantValue : Variable.value;
        }
        set
        {
            ConstantValue = value;
            if (Variable != null)
                Variable.value = value;
        }
    }
}

public abstract class AbstractSet<T> : ScriptableObject
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

public abstract class AbstractEnum<T> : ScriptableObject
{
    public string Name;
}