using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rigidBody;

    [SerializeField] Animator animator;

    float Speed = 2500f;

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rigidBody.velocity = transform.forward * Speed * Time.deltaTime;
            //this.transform.Translate(vector3.forward * Time.deltaTime);
            animator.SetFloat("animSpeed", 1f);
        }
        if (Input.GetMouseButtonUp(0))
        {
            rigidBody.velocity = Vector3.zero;

            animator.SetFloat("animSpeed", 0);
        }
    }
}
