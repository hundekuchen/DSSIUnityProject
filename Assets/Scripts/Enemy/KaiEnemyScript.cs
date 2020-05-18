using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaiEnemyScript : MonoBehaviour
{
    public GameObject enemyKaiBullet;
    float shootWait;
    float shootDelay;
    

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<EnemyStats>().setData(500, 0.5f,10f); //hitpoints, speed, armor TODO more attributes
        shootDelay = 5.50f;
        shootWait = 0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 dirToPlayer = GameObject.FindGameObjectWithTag("player").transform.position - transform.position;
        //Debug.Log(Vector3.Magnitude(dirToPlayer));
        transform.rotation = Quaternion.LookRotation(dirToPlayer, Vector3.up);
        if (Vector3.SqrMagnitude(dirToPlayer) > 3f)
        {
            //transform.position = transform.position + transform.forward * GetComponent<EnemyStats>().getSpeed();
            transform.Translate(transform.forward * GetComponent<EnemyStats>().getSpeed() * Time.deltaTime, Space.World);
            float sp = GetComponent<EnemyStats>().getSpeed();
            Debug.Log("speed = " + sp);
        }


        shootWait += Time.deltaTime;
        if (shootWait > shootDelay)
        {
            Instantiate(enemyKaiBullet, transform.position + 2 * transform.forward, transform.rotation);
            shootWait = 0f;
        }
    }
}
