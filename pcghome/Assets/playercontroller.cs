using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.LeftArrow))
{
    Vector3 position = this.transform.position;
    position.x-=2;
    this.transform.position = position;
}else if (Input.GetKeyDown(KeyCode.RightArrow))
{
    Vector3 position = this.transform.position;
    position.x+=2;
    this.transform.position = position;
}else if  (Input.GetKeyDown(KeyCode.UpArrow))
{
    Vector3 position = this.transform.position;
    position.z+=2;
    this.transform.position = position;
}else if  (Input.GetKeyDown(KeyCode.DownArrow))
{
    Vector3 position = this.transform.position;
    position.z-=2;
    this.transform.position = position;
}
    }
}
