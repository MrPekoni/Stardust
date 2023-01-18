using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starcollect : MonoBehaviour
{
	public static int starscollected;
	private BoxCollider2D box;
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
			Debug.Log("First Star Destroyed");
		}
		if (starscollected == 2)
		{
			GameObject.Destroy(GameObject.Find("Star (1)"));
			Debug.Log("Second Star Destroyed");
		}
		if (starscollected == 3)
		{
			GameObject.Destroy(GameObject.Find("Star (2)"));
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