using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 球 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rigidbody=GetComponent<Rigidbody>();
        if(Input.GetKey(KeyCode.LeftArrow)){
            rigidbody.AddForce(-1f,0,0);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            rigidbody.AddForce(1f,0,0);
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            rigidbody.AddForce(0,0,1f);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
             rigidbody.AddForce(0,0,-1f);
        }
    }
    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag=="カプセル"){
            Destroy(collision.gameObject);
        }
    }
}
