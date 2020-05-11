using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class casingScript : MonoBehaviour
{
    float speed;
    float age;
    float destroyTime;
    // Start is called before the first frame update
    void Start()
    {
        destroyTime = 2.0f;
        age = 0.0f;
        speed = 20.5f;
        //Debug.Log(transform.forward);
        Destroy(gameObject, destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
    
    }
   
}
