using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public float horizontal;
	private float speed = 8f;
	public float jumpingpower = 7f;
	private bool isfacingright = true;
	private Animator animator;
	[SerializeField] private Transform Groundcheck;
	[SerializeField] private LayerMask groundLayer;
	[SerializeField] private Rigidbody2D rb;

	// Start is called before the first frame update
	void Start()
	{
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update() 
	{
		horizontal = Input.GetAxisRaw("Horizontal");

		rb.velocity = new Vector2(horizontal*3f, rb.velocity.y);
		animator.SetFloat("movementspeed", horizontal);

		if (Input.GetButtonDown("Jump") && isgrounded())
		{
			rb.velocity = new Vector2(rb.velocity.x, jumpingpower);
		}

		if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
		{
			rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.2f);
		}
		Console.WriteLine(horizontal);
		Flip();
	}
	private void Fixedupdate()
	{
		rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
	}
	private bool isgrounded()
	{
		return Physics2D.OverlapCircle(Groundcheck.position, 0.2f, groundLayer);
	}

	private void Flip()
	{
		if (isfacingright && horizontal < 0f || !isfacingright && horizontal > 0f)
		{
			isfacingright = !isfacingright;
			Vector3 localScale = transform.localScale;
			localScale.x *= -1f;
			transform.localScale = localScale;
		}
	}
}


