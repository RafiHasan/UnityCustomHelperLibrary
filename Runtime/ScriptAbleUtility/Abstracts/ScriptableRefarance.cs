using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableRefarance<T>
{
    public bool UseConstant = true;
    public T ConstantValue;
    public ScriptableVariable<T> Variable;

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
