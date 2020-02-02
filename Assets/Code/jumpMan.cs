using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpMan : MonoBehaviour
{
  Rigidbody rb;
  Vector3 floor;
  AudioSource m;

  public float jumpHeight = 1f;
  public float jumpHeightX = 0.1f;

  void Awake()
  {
    rb = GetComponent<Rigidbody>();
    floor = transform.position;
    m = GameObject.Find("machineSound").GetComponent<AudioSource>();
  }

  void FixedUpdate()
  {
    transform.position = new Vector3(-1.5f, transform.position.y, transform.position.z);
    GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    transform.localRotation = Quaternion.identity;

    m.volume = 1f + (transform.position.y - floor.y) * 0.25f;

    if(Input.GetButtonDown("Jump"))
    {
      rb.AddForce(new Vector3(0f, jumpHeight, jumpHeightX), ForceMode.Impulse);
    }
  }
}
