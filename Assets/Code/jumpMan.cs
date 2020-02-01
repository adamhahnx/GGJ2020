using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpMan : MonoBehaviour
{
  float floor;
  bool jumping = false;

  void Awake()
  {
    floor = transform.position.y;
  }

  public void Jump()
  {
    jumping = true;
    transform.position += new Vector3(0f, 1f, 0f);
  }

  void Update()
  {
    if(jumping)
    {
      transform.position = new Vector3(0f, Mathf.Lerp(transform.position.y, transform.position.y + 1f, Time.deltaTime), 0f);
    }
    else
    {
      transform.position = new Vector3(0f, Mathf.Lerp(transform.position.y, floor, Time.deltaTime), 0f);
    }
  }
}
