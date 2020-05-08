using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TracksScript : MonoBehaviour
{
    float destroyTime = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        destroyTime = 3.0f;
        Destroy(gameObject, destroyTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {


    }
}