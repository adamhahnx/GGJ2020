using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeHeight : MonoBehaviour
{
    Transform fix;
    float turnLast;
    float turn;
    AudioSource m;

    void Awake()
    {
        fix = GameObject.Find("fixPipe").transform;
        m = GameObject.Find("machineSound").GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        turn = fix.eulerAngles.z;

        if (turn != turnLast)
        {
          Crank(turn - turnLast);
        }

        turnLast = fix.eulerAngles.z;
    }

    void Crank(float amount)
    {
      transform.position += new Vector3(0f, (amount / 360f), 0f);

      m.pitch = transform.position.y - 0.4f;

      if(transform.position.y < 0.6f)
      {
        transform.position = new Vector3(transform.position.x, 0.6f, transform.position.z);
      }
      else if(transform.position.y > 1.4f)
      {
        transform.position = new Vector3(transform.position.x, 1.4f, transform.position.z);
      }
    }
}
