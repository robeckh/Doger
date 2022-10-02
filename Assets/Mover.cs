using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float moveSpeed = 2.0f;
 
    // Start is called before the first frame update
    void Start()
    {
        PrintInstroductions();
    }

    // Update is called once per frame
    void Update()
    {
       MovePlayer();
    }

    void PrintInstroductions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your Player with WASD or arrow keys");
    }

    void MovePlayer()
    {
        var xValue = (Input.GetAxis("Horizontal") * Time.deltaTime) * moveSpeed;
        var zValue = (Input.GetAxis("Vertical")* Time.deltaTime) * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
