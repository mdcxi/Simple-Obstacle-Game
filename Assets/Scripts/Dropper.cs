using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Rigidbody rigidbody;
    [SerializeField] float timeToWait = 3f;
    
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;

        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait)
        {
            meshRenderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
