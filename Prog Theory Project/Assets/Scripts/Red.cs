using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Red : Shape
{
    protected override void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RedAction();
        }
    }

    void RedAction()
    {
        Name = "Inheritence";
        displayText.text = $"{Name}, ({color}): child classes deriving behavior from parent classes.";
        Rotate(rotation);
    }
}
