using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeScript : MonoBehaviour
{
    public int life;
    // Start is called before the first frame update
    void Start()
    {
        life = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage(int damage)
    {
        life -= damage;
        if(life<0)
        {
            Debug.Log("Game Over");
        }
    }
}
