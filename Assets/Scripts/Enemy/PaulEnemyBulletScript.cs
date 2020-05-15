using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaulEnemyBulletScript : MonoBehaviour
{
    float speed;
    float age;
    float destroyTime;
    // Start is called before the first frame update
    void Start()
    {
        destroyTime = 1.0f;
        age = 0.0f;
        speed = 1f;
        //Debug.Log(transform.forward);
        //Destroy(gameObject, destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position += step * transform.forward;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            Debug.Log("treffer");
            other.gameObject.GetComponent<EnemyDamage>().takeDamage(10);
        }
    }
}