using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;
using Microsoft.CSharp.RuntimeBinder;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed, jumpForce;
    private Rigidbody2D rig;
    public StringComparer cc;

    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput=Input.GetAxis("Horizontal");
        Transform.position+=new Vector3(moveinp,0,0)*Time.deltaTime*speed;
        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rig.velocity.y) < 0.001f)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
        
    }
}