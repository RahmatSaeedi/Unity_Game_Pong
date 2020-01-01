using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    public float movementSpeed;
    public string inputAxisName;
    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw(this.inputAxisName);
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0,v) * movementSpeed;
    }
}
