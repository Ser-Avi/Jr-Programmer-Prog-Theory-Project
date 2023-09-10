using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    //ENCAPSULATION
    [SerializeField] protected string Name {get; set;}
    [SerializeField] protected string color = "None";
    [SerializeField] protected Vector3 rotation;
    [SerializeField] protected TextMeshProUGUI displayText;

    protected virtual void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            displayText.text = $"{Name}, {color}";
            Rotate();   //ABSTRACTION
        }
    }

    //POLYMORPHISM
    protected virtual void Rotate()
    {
        Rigidbody shapeRb = this.GetComponent<Rigidbody>();
        shapeRb.AddTorque(new Vector3(1, 0, 0));
    }

    protected virtual void Rotate(Vector3 rotation)
    {
        Rigidbody shapeRb = this.GetComponent<Rigidbody>();
        shapeRb.AddTorque(rotation);
    }
}
