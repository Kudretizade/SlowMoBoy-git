using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rigidBody;

    float Speed=1000f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rigidBody.velocity = transform.forward * Speed * Time.deltaTime;
            //this.transform.Translate(vector3.forward * Time.deltaTime);
        }
        if (Input.GetMouseButtonUp(0))
		    {
          rigidBody.velocity = Vector3.zero;
	    	}
    }
}
