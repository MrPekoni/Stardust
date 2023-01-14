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
		GameObject.Find("Player").GetComponent<Rigidbody2D>().gravityScale += -0.2f;
		Physics2D.OverlapBox(Vector2 )
	}
	
	// Update is called once per frame
	void Update()
	{

	}
 //   private void OnCollisionEnter2D(Box,)
 //   {
//		GameObject.Find("Player").GetComponent<Rigidbody2D>().gravityScale += -0.2f;
//		Debug.Log("Contact with Player made! Gravity reduced.");
//		GameObject.Destroy(gameObject);
 //   }
}
