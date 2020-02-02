using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPress : MonoBehaviour
{
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
          transform.localPosition = new Vector3(-0.05f, transform.position.y, transform.position.z);
        }
        else if (Input.GetButtonUp("Jump"))
        {
          transform.localPosition = new Vector3(0f, transform.position.y, transform.position.z);
        }
    }
}
