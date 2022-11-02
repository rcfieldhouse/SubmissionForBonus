using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    private float LRMove;
    CapsuleCollider coll;
    public LayerMask m_WhatIsGround;
    private bool m_IsGrounded;
    private Vector3 JumpVEC = new Vector3(0.0f, 10.0f, 0.0f);
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        coll = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
       LRMove = Input.GetAxisRaw("Horizontal")*3;

        if (Input.GetButtonDown("Jump") == true && isGrounded() == true)
        {
            rb.AddForce(JumpVEC, ForceMode.Impulse);
        }


       rb.velocity = new Vector3(LRMove, rb.velocity.y, 0.0f);
        if (rb.gameObject.transform.position.y < -5.0f)
        {
            CharacterHealth.instance.TakeDamage();
        }
    }
    public bool isGrounded()
    {
        m_IsGrounded = Physics.Raycast(coll.bounds.center - Vector3.down / 10, Vector3.down,1.2f, m_WhatIsGround);
        return Physics.Raycast(coll.bounds.center - Vector3.down / 10, Vector3.down, 1.2f, m_WhatIsGround);
    }
}
