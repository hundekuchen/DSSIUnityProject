using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    int hitpoints;

    // Start is called before the first frame update
    void Start()
    {
        hitpoints = 1000;
    }

    // Update is called once per frame
    public void takeDamage(int damage)
    { 
        hitpoints -= damage;
        Debug.Log("hitpoints = " + hitpoints);
        if (hitpoints < 0)
        {
            Destroy(gameObject);
        }
    }
}
