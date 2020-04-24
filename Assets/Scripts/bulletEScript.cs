using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletEScript: MonoBehaviour
{
    float speed;
    float destroyTime;

    // Start is called before the first frame update
    void Start()
    {
        destroyTime = 4.0f;
        speed = 10.0f;
        Destroy(gameObject, destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position += step * transform.forward;
    }

    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("player"))
    //   {
    //        other.gameObject.GetComponent<CasingScript>().takeDamage(5);
    //        Destroy(gameObject);
    //    }
    //}
}
