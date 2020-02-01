using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeHeight : MonoBehaviour
{
    Transform fix;
    float turnLast;
    float turn;

    void Awake()
    {
        fix = GameObject.Find("fixPipe").transform;
    }

    void FixedUpdate()
    {
        turn = fix.eulerAngles.z;

        if (turn != turnLast)
        {
          Debug.Log(turn - turnLast);
          Crank(turn - turnLast);
        }

        turnLast = fix.eulerAngles.z;
    }

    void Crank(float amount)
    {
      transform.position += new Vector3(0f, amount / 400f, 0f);
      if(transform.position.y < 0.6f)
      {
        transform.position = new Vector3(transform.position.x, 0.6f, transform.position.z);
      }
      else if(transform.position.y > 1.25f)
      {
        transform.position = new Vector3(transform.position.x, 1.25f, transform.position.z);
      }
    }
}
