using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starcollect : MonoBehaviour
{
	private BoxCollider2D box;
	[SerializeField] object Player;
	// Start is called before the first frame update
	void Start()
	{
		//Get the collider
		box = GetComponent<BoxCollider2D>();
	}

	private void OnCollisionEnter2D()
	{
		GameObject.Find("Player").GetComponent<Rigidbody2D>().gravityScale += -0.2f;
		Debug.Log("Contact with Player made! Gravity reduced.");
		GameObject.Destroy(GameObject.Find("Star"));
	}
	// Update is called once per frame
	void Update()
	{
		var point = new Vector2(transform.position.x, transform.position.z);
		var size = new Vector2(box.size.x, box.size.y);
		Physics2D.OverlapBoxAll(point, size, 0f);
	}
}