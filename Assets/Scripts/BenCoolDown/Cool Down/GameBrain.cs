using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameBrain : MonoBehaviour
{
    public Text killCount;
    int kills;
    bool gotKill;

    public float shootDelay;
    public float shootDelayM2;
    float shootWait;
    float shootWaitM2;

    public GameObject hud;

    
    // Start is called before the first frame update
    void Start()
    {
        gotKill = false;
        kills = 0;
        Debug.Log(kills);
        killCount.text = "Kills: " + kills.ToString(); //<-- works

        shootWait = 10.0f;
        shootWaitM2 = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (gotKill) //<-- doesn't work
        {
            kills++;
            Debug.Log("Kills:aa " + kills);
            gotKill = false;
        }
        Debug.Log(kills);
        killCount.text = "Kills: " + kills.ToString();

        if (Input.GetMouseButton(0) && shootWait > shootDelay)
        {
            //Debug.Log("hello");
            //Instantiate(bullet, transform.position + 1 * transform.forward, transform.rotation);
            shootWait = 0f;
        }
        if (Input.GetMouseButton(1) && shootWaitM2 > shootDelayM2)
        {
            //Instantiate(bulletm2, transform.position + 1 * transform.forward, transform.rotation);
            shootWaitM2 = 0f;
            
            hud.GetComponent<SkillBar>().beginCooldown(shootDelayM2); //Ability Cooldown Initiation
            //todo: hitmarker + sound
        }
        shootWait += Time.deltaTime;
        shootWaitM2 += Time.deltaTime;
    }

    public bool KilledEnemy(int yees)
    {
        gotKill = true; //<-- works
        Debug.Log(yees);
        kills++; // <-- works
        //Debug.Log("Kills: " + kills); //<-- works
        killCount.text = "kills: " + kills.ToString(); //nope*/
        return gotKill;
    }
}
