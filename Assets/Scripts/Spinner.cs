using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngle = 0f;
    [SerializeField] float yAngle = 2f;
    [SerializeField] float zAngle = 0f;

    // Update is called once per frame
    void Update()
    {
       Rotate(xAngle, yAngle, zAngle);
    }

    void Rotate(float xAngle, float yAngle, float zAngle)
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
