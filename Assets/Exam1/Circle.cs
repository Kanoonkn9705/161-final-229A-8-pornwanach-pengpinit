using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape
{
    private float Redius = 4;

    public override void Resize()
    {
        Debug.Log($"Resizing Shape");
        Debug.Log($"{ShapeName} is Resizing in {ShapeName} class");
    }
    public override void Draw()
    {
        Debug.Log($"Drawing : {ShapeName}");
    }

    public override float CalculateArea()
    {
        float area = Mathf.PI * Redius * Redius;
        return area;
    }

    private void Start()
    {
        Init("Circle");
        Resize();
        Draw();
        Debug.Log($"{ShapeName} Redius : {Redius}");
        Debug.Log($"{ShapeName} Area : {CalculateArea()}");
    }
}
