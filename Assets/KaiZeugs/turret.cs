using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret : MonoBehaviour
{
    public GameObject bullet;
    public GameObject casing;
    float turnSpeed;
    float shootDelay;
    float shootWait;
    // Start is called before the first frame update
    void Start()
    {
        turnSpeed = 10f;
        shootDelay = 0.02f;
    }

    // Update is called once per frame
    void Update()
    {
        float singleStep = turnSpeed * Time.deltaTime;
        Vector3 mouseScreenPos = Input.mousePosition; //has only x,y components
        mouseScreenPos.z = Camera.main.transform.position.y - transform.position.y;  //distance from Camera to player
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(mouseScreenPos); //convert mouseSreenPos from 2D to 3D with the missing z component to distance from Camera
        Vector3 dir = mouseWorldPos - transform.position; //direction from player to  mouseWorldPosition
        Vector3 turn = Vector3.RotateTowards(transform.forward, dir, singleStep, 0.0f); //calc next step towards diretion of mouseWorldPosition with float speed (in rad/sek)
        turn.y = 0.0f;  //make sure the rotation stays in the x-z-plane
        transform.rotation = Quaternion.LookRotation(turn, Vector3.up); //use quaternion to update rotation towards "turn" (slow turn) or "dir" (instant turn)
                                                                        //transform.LookAt(mouseWorldPos); //Alternativ - but without slow turn

        if (Input.GetMouseButton(0) && shootWait > shootDelay)
        {
            //Debug.Log("hello");
            Instantiate(bullet, transform.position + 1.1f * transform.forward, transform.rotation);
            Instantiate(casing, transform.position + 0.3f * transform.forward + 0.3f * transform.right, transform.rotation);
            shootWait = 0f;
            
        }
        shootWait += Time.deltaTime;

    }
}
