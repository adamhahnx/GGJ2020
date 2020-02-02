using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixTurn : MonoBehaviour
{
    Camera cam;
    Vector3 sc;
    GameObject turn;
    AudioSource c;

    void Awake()
    {
      cam = GameObject.Find("camera").GetComponent<Camera>();
      turn = transform.GetChild(0).gameObject;
      c = GameObject.Find("fixSound").GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        if(cam.WorldToScreenPoint(transform.position).z < 1.4f)
        {
          float x = cam.WorldToScreenPoint(transform.position).x / Screen.width;
          float y = cam.WorldToScreenPoint(transform.position).y / Screen.height;
          if (x < 0.6f && x > 0.4f && y < 0.6f && y > 0.4f)
          {
              transform.Rotate(transform.forward * Input.GetAxis("Mouse ScrollWheel") * 50f);

              if(Input.GetAxis("Mouse ScrollWheel") != 0.0f)
              {
                  c.Play();
              }

              if (transform.eulerAngles.z > 310f)
              {
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 310f);
              }
              else if (transform.eulerAngles.z < 130)
              {
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 130f);
              }
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
