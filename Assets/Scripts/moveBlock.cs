using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBlock : MonoBehaviour
{

    float t;
    // Start is called before the first frame update
    void Start()
    {
        t = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        t += Time.deltaTime;
        transform.position = new Vector3(0f, Mathf.Sin(0.3f*t), 0f);
    }
}
