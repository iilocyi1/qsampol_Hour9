using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountBounce : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        
        print("Object has entered the collider" + gameObject.name);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
