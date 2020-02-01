using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixTurn : MonoBehaviour
{
    Camera cam;
    Vector3 sc;

    void Awake()
    {
      cam = GameObject.Find("camera").GetComponent<Camera>();
    }

    void FixedUpdate()
    {
        float x = cam.WorldToScreenPoint(transform.position).x / Screen.width;
        float y = cam.WorldToScreenPoint(transform.position).y / Screen.height;
        if (x < 0.55f && x > 0.45f && y < 0.55f && y > 0.45f)
        {
          transform.Rotate(transform.forward * Input.GetAxis("Mouse ScrollWheel") * 100f);
        }
    }
}
