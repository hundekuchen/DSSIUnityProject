using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comeInAgain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveVector;
        if (transform.position.x > 35)
        {
            moveVector = new Vector3(-70, 0, 0);
            transform.position = transform.position + moveVector;
        }
        if (transform.position.x < -35)
        {
            moveVector = new Vector3(70, 0, 0);
            transform.position = transform.position + moveVector;
        }
        /*if (transform.position.y != 1)
        {
            transform.position = new Vector3 (transform.position.x,1,transform.position.z);
        }*/
        if (transform.position.z > 15)
        {
            moveVector = new Vector3(0, 0, -30);
            transform.position = transform.position + moveVector;
        }
        if (transform.position.z < -15)
        {
            moveVector = new Vector3(0, 0, 30);
            transform.position = transform.position + moveVector;
        }
    }
}
