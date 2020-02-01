using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixTurn : MonoBehaviour
{
    Camera cam;
    Vector3 sc;
    GameObject turn;

    void Awake()
    {
      cam = GameObject.Find("camera").GetComponent<Camera>();
      turn = transform.GetChild(0).gameObject;
    }

    void FixedUpdate()
    {
        if(cam.WorldToScreenPoint(transform.position).z < 1.4f)
        {
          float x = cam.WorldToScreenPoint(transform.position).x / Screen.width;
          float y = cam.WorldToScreenPoint(transform.position).y / Screen.height;
          if (x < 0.6f && x > 0.4f && y < 0.6f && y > 0.4f)
          {
            transform.Rotate(transform.forward * Input.GetAxis("Mouse ScrollWheel") * 100f);
            turn.SetActive(true);
          }
          else
          {
            turn.SetActive(false);
          }
        }
        else
        {
          turn.SetActive(false);
        }
    }
}
