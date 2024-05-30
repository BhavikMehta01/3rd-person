using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour 
{
	public enum Axis 
	{
		X, Y, Z
	}

	public Axis rotateAxis = Axis.Z;
	public float speed;

    void Update()
    {
        switch (rotateAxis)
        {
            case Axis.X:
                transform.Rotate(Time.deltaTime * speed, 0f, 0f);
                break;
            case Axis.Y:
                transform.Rotate(0f, Time.deltaTime * speed, 0f);
                break;
            case Axis.Z:
                transform.Rotate(0f, 0f, Time.deltaTime * speed);
                break;
            default:
                break;
        }
    }
}