using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    //caching a reference
    MeshRenderer renderer ;
    Rigidbody rigidBody;

    [SerializeField] float EstimatedTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > EstimatedTime)
        {
            renderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
