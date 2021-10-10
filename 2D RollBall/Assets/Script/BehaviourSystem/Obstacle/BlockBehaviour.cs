using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehaviour : MonoBehaviour
{
    public float rotateSpeed;
    private void Update()
    {
        transform.Rotate(Time.deltaTime*rotateSpeed*new Vector3(0,0,5),Space.Self);
    }
}
