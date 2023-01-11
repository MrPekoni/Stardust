using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float horizontal;
    private float speed=8f;
    private float jumpingpower;
    private bool isfacingright=true;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private Layermask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.veloclty.x, jumpingPower)
        }
        Flip();

    }
    private void Fixedupdate()
    {
        rb.velocity = new Vector2D(horizontal * speed, rb.velocity.y);
    }
    private void Flip()
    {
        if (isfacingright && horizontal < 0f || !isfacingright && horizontal > 0);
        {
            isfacingright = !isfacingright;
            Vector3 localscale = transform.localscale;
            localscale.x *= -1f;
            transform.localscale = localscale;  
        }

    private bool isgrounded();
        {
            return Physics2D.Overlap(groundCheck.position, 0.2f, groundLayer);
        }

}


