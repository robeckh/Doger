using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int counter = 0;

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag != "Hit")
        {
            counter++;
            Debug.Log($"You have bumbed into a thing {counter} many times");
        }
       
    }
}
