using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBlock : MonoBehaviour
{

    float t;
    float speed;
    float peter;
    // Start is called before the first frame update
    void Start()
    {
        speed = 2.0f;
        t = 0f;
        peter = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        t += Time.deltaTime;

        transform.position = new Vector3(0f, Mathf.Sin(speed*t), 0f);
        Debug.Log("miaumiau");

    }

    //test by ben
}
