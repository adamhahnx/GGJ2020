using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPan : MonoBehaviour
{
    Vector2 next = new Vector2 (0, 0);
    void Update()
    {
      next.y += Input.GetAxis("Mouse X");
      next.x += -Input.GetAxis("Mouse Y");
      transform.eulerAngles = (Vector2) next * 2f;
    }
}
