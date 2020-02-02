using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpHeight : MonoBehaviour
{
    Transform fix;
    float turnLast;
    float turn;

    jumpMan j;

    void Awake()
    {
        fix = GameObject.Find("fixJump").transform;
        j = GetComponent<jumpMan>();
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
      j.jumpHeight += amount / 100f;
    }
}
