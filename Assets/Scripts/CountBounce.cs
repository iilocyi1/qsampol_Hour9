using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countbounce : MonoBehaviour
{
    public int x = 0;
    
    void OnTriggerEnter()
    {
        if (x < 1000)
        {
            print(x++);
         }
       
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
