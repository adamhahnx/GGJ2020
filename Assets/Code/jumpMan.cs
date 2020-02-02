using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpMan : MonoBehaviour
{
  Rigidbody rb;
  Vector3 floor;
  AudioSource m;
  AudioSource c;
  AudioSource j;

  public float jumpHeight = 1f;
  public float jumpHeightX = 0.1f;

  string guiOut;

  void Awake()
  {
    rb = GetComponent<Rigidbody>();
    floor = transform.position;
    m = GameObject.Find("machineSound").GetComponent<AudioSource>();
    c = GameObject.Find("jumpSound").GetComponent<AudioSource>();
    j = GameObject.Find("radioSound").GetComponent<AudioSource>();
    Cursor.visible = false;
  }

  void FixedUpdate()
  {
    transform.position = new Vector3(-1.5f, transform.position.y, transform.position.z);
    GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    transform.localRotation = Quaternion.identity;

    m.volume = 0.4f + ((transform.position.y - floor.y) * 0.6f);

    if(Input.GetButtonDown("Jump"))
    {
      rb.AddForce(new Vector3(0f, jumpHeight, jumpHeightX), ForceMode.Impulse);
      c.Play();
    }

    if(transform.position.z > 1.8f)
    {
      j.pitch = Mathf.Lerp(j.pitch, 2f, Time.deltaTime * 0.1f);
      j.volume = Mathf.Lerp(j.volume, 1.5f, Time.deltaTime * 0.1f);
      Invoke("PrintGuiForever", 3f);
      Invoke("EndgameIsAGoodMovie", 4f);
    }
  }

  void PrintGuiForever()
  {
    PrintGui("Assets/Code/script.cs: error: SATISFYING ENDING EXPECTED\n");
    Invoke("PrintGuiForever", 0.3f);
  }

  void PrintGui(string input)
  {
    guiOut += input;
  }

  void OnGUI()
  {
    GUI.Label(new Rect(10, 10, 1000, 2000), guiOut);
  }

  void EndgameIsAGoodMovie()
  {
    Application.Quit();
  }
}
