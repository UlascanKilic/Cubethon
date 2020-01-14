using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Transform ground;
    public float forwardForce = 200;
    public float sidewaysForce = 500f;
    public float groundSize;
    public float pushForce = 300f;
    

  /*  void GoLeft()
    {
        rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        if (rb.position.x <= (-ground.localScale.x / 2) + 10)
        {
            rb.AddForce(pushForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
    void GoRight()
    {
        rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        if (rb.position.x >= (ground.localScale.x/2) - 10)
        {
            rb.AddForce(-pushForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }*/
    // Update is called once per frame
    void FixedUpdate()
    {
      /*  if(rb.position.x < 0)
        {
            if (isFirstTimeToRight)
            {
                isFirstTimeToRight = false;
                pushForce += 30f;
                GoRight();
                
            }
            else
            {
                Invoke("GoRight", 0.5f);
            }
        }

        if(rb.position.x > 0)
        {
            if (isFirstTimeToLeft)
            {
                isFirstTimeToLeft = false;
                pushForce += 30f;
                GoLeft();
               
            }
            else
            {
                Invoke("GoLeft()", 0.5f);
            }
        }*/
        
    }
}
