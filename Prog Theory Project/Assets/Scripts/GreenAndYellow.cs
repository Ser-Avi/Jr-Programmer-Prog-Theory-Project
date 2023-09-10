using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GreenAndYellow : Shape
{
    [SerializeField] string definition;
    protected override void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GreenAndYellowAction();
        }
    }
    private void GreenAndYellowAction()
    {
        if (color == "Yellow")
        {
            Name = "Encapsulation";
        }
        else
        {
            Name = "Polymorphism";
        }
        displayText.text = $"{Name}, ({color}): {definition}";
        Rotate(rotation);
    }
}
