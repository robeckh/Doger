using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
       
        if(other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.yellow;
            gameObject.tag = "Winner"; 
            Debug.Log("Finished");
            var winningText = GameObject.Find("WinningText");
            winningText.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
