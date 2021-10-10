using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed;
    private Rigidbody2D Rigid2D;
    public bool UseKeyboard = false;

    private void Awake()
    {
        Rigid2D = gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 acc2D = new Vector2();
        if (UseKeyboard)
        {
             acc2D = new Vector2(Input.GetAxis("Horizontal")*speed, Input.GetAxis("Vertical")*speed);
             Rigid2D.AddForce(acc2D);
        }
        else
        {
            Vector3 acc = Input.acceleration;
            acc2D = new Vector2(acc.x, acc.y);
            Rigid2D.AddForce(acc2D);
        }
    }
}
