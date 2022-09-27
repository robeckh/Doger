using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float moveSpeed = 2.0f;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var xValue = (Input.GetAxis("Horizontal") * Time.deltaTime) * moveSpeed;
        var zValue = (Input.GetAxis("Vertical")* Time.deltaTime) * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
