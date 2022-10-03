 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;

    [SerializeField] float timeToWait = 3f;
    [SerializeField] bool makeInvisible = true;
    

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        ChangeDropperVisibillity(false, makeInvisible);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait)
        {
            ChangeDropperVisibillity(true, makeInvisible);
        }
    }

    void ChangeDropperVisibillity(bool isActive, bool makeInvisible)
    {
        if(makeInvisible)
        {
            renderer.enabled = isActive;
        }
        
        rigidbody.useGravity = isActive;
    }
}
