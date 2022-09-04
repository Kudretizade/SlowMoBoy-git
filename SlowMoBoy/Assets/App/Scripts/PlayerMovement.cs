using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody m_Rigidbody;

    GameObject Player;

    float m_Speed=10f;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            m_Rigidbody.velocity = transform.forward * m_Speed * Time.deltaTime;
            //this.transform.Translate(vector3.forward * Time.deltaTime);
        }
    }
}
