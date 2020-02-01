using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    CharacterController cc;
    Transform cam;

    void Awake()
    {
        cc = GetComponent<CharacterController>();
        cam = GameObject.Find("camera").transform;
    }

    void Update()
    {
      cc.Move(cam.right * Input.GetAxis("Horizontal") * 2f * Time.deltaTime);
      cc.Move(cam.forward * Input.GetAxis("Vertical") * 2f * Time.deltaTime);

      if(!cc.isGrounded)
      {
        cc.Move(transform.up * -3f * Time.deltaTime);
      }
    }
}
