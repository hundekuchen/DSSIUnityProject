using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaphaelEnemyBullet : MonoBehaviour
{
    float speed;
    float destroytime;

    // Start is called before the first frame update
    void Start()
    {
        destroytime = 2.0f;
        speed = 10f;

        Destroy(gameObject, destroytime);
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position += step * transform.forward;

        //void OnTriggerEnter(Collider other)
        //{
        //   if (other.gameObject.CompareTag("player"))
        //    {
        //       other.gameObject.GetComponent<moveScript>().takeDamage(10);
        //    }
        //}
    }
}
