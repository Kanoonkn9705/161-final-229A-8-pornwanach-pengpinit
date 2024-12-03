using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    private string shapeName;
    protected string ShapeName
    {
        get
        {
            return shapeName;
        }
        set
        {
            shapeName = value;
        }
    }

    public void Init(string newShapeName)
    {
        shapeName = newShapeName;
    }

    public abstract float CalculateArea();

    public virtual void Resize()
    {

    }

    public abstract void Draw();

}
