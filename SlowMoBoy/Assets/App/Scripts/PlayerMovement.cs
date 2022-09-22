using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rigidBody;

    [SerializeField] Animator animator;

    float Speed = 270f;

    void Start()
    {
        Time.timeScale = 1;
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            
            //this.transform.Translate(vector3.forward * Time.deltaTime);
            if("SampleScene" == SceneManager.GetActiveScene().name)
            {

            }
            else if ("OptionsScene" == SceneManager.GetActiveScene().name)
            {

            }
            else
            {
                rigidBody.velocity = transform.forward * Speed * Time.deltaTime;
                animator.SetFloat("animSpeed", 1f);
            }
            
        }
        if (Input.GetMouseButtonUp(0))
        {
            rigidBody.velocity = Vector3.zero;

            animator.SetFloat("animSpeed", 0);
        }
    }
}
