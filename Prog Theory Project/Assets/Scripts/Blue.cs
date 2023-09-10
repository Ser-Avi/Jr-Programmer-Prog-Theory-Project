using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue : Shape
{
    string definition = "reducing duplicate code by “abstracting out” repeated details or information";
    protected override void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            BlueAction();
        }
    }

    void BlueAction()
    {
        Name = "Abstraction";
        displayText.text = $"{Name}, ({color}): {definition}.";
        Rotate(rotation);
    }

    protected override void Rotate(Vector3 rotation)
    {
        base.Rotate(rotation);
        Rigidbody shapeRb = this.GetComponent<Rigidbody>();
        shapeRb.AddForce(new Vector3(10,0,0));
    }
}
