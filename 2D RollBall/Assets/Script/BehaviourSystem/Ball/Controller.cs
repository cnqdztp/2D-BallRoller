using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using Unity.Mathematics;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed;
    private Rigidbody2D Rigid2D;
    public bool UseKeyboard = false;
    public int pow;

    private void Awake()
    {
        Rigid2D = gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 acc2D = new Vector2();
        if (UseKeyboard)
        {
            // acc2D = new Vector2(horizontal * speed, vertical * speed);
            // Rigid2D.AddForce(acc2D);
        }
        else
        {
            Vector3 acc = Input.acceleration;
            var vertical = math.pow(acc.x, pow);
            var horizontal = math.pow(acc.y, pow);
            acc2D = new Vector2(acc.x, acc.y);
            Rigid2D.AddForce(acc2D);
        }
    }
}