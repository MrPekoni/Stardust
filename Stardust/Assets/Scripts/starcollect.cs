using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starcollect : MonoBehaviour
{
	public static int starscollected;
	private BoxCollider2D box;
	public AudioClip Starcollect1;
	public AudioClip Starcollect2;
	public AudioClip Starcollect3;
	public SFX sfx;
	// Start is called before the first frame update
	void Start()
	{
		//Get the collider
		box = GetComponent<BoxCollider2D>();
		starscollected = (0);
	}

	void OnTriggerEnter2D()
	{
		var player = GameObject.Find("Player");
		player.GetComponent<Rigidbody2D>().gravityScale += -0.2f;
		Debug.Log("Contact with Player made! Gravity reduced.");
		starscollected += 1;
		if (starscollected == 1)
        {
			GameObject.Destroy(GameObject.Find("Star"));
			sfx.PlayCollect1();
			Debug.Log("First Star Destroyed");
		}
		if (starscollected == 2)
		{
			GameObject.Destroy(GameObject.Find("Star (1)"));
			sfx.PlayCollect2();
			Debug.Log("Second Star Destroyed");
		}
		if (starscollected == 3)
		{
			GameObject.Destroy(GameObject.Find("Star (2)"));
			sfx.PlayCollect3();
			Debug.Log("Third Star Destroyed");
		}
	}
	// Update is called once per frame
	void Update()
	{
		var point = new Vector2(transform.position.x, transform.position.z);
		var size = new Vector2(box.size.x, box.size.y);
		Physics2D.OverlapBoxAll(point, size, 0f);
	}

}