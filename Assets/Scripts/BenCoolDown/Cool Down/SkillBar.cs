using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillBar : MonoBehaviour
{
    public Image imageCooledown;
    float cd;
    bool isCooldown;

    // Start is called before the first frame update
    void Start()
    {
        isCooldown = false;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButton(1))
        {
            isCooldown = true;
        }*/

        if (isCooldown)
        {
            Debug.Log("right klick");
            imageCooledown.fillAmount += 1 / cd * Time.deltaTime;

            if (imageCooledown.fillAmount >= 1)
            {
                imageCooledown.fillAmount = 0;
                isCooldown = false;
            }
        }
    }


    public void beginCooldown(float cooldown)
    {
        //imageCooledown.fillAmount += 1 / cooldown * Time.deltaTime;
        isCooldown = true;
        cd = cooldown;
        imageCooledown.fillAmount += 1 / cd * Time.deltaTime;
        Debug.Log("rk");
        if (imageCooledown.fillAmount >= 1)
        {
            imageCooledown.fillAmount = 0;
            Debug.Log("done");
        }
    }
}
