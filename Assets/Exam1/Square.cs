using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    private int side = 4;

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
        int area = side * side;
        return area;
    }

    private void Start()
    {
        Init("Square");
        Resize();
        Draw();
        Debug.Log($"{ShapeName} Side : {side}");
        Debug.Log($"{ShapeName} Area : {CalculateArea()}");
    }


}
