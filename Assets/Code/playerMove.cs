using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    CharacterController cc;

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
      cc.Move(transform.right * Input.GetAxis("Horizontal") * 2f * Time.deltaTime);
      cc.Move(transform.forward * Input.GetAxis("Vertical") * 2f * Time.deltaTime);
    }
}
