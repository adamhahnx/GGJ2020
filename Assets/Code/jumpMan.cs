using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpMan : MonoBehaviour
{
  Rigidbody rb;
  public Vector3 floor;
  AudioSource m;

  public float jumpHeight = 1f;

  void Awake()
  {
    rb = GetComponent<Rigidbody>();
    floor = transform.position;
    m = GameObject.Find("machineSound").GetComponent<AudioSource>();
  }

  void FixedUpdate()
  {
    GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

    m.pitch = 1f + (transform.position.y - floor.y) * 0.25f;

    if(Input.GetButtonDown("Jump"))
    {
      rb.AddForce(new Vector3(0f, jumpHeight, 0f), ForceMode.Impulse);
    }
  }
}
