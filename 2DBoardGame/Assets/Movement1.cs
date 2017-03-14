/* using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour
{
	float speed = 5.0f;

	[SerializeField]
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		RaycastHit2D hitUp = Physics2D.Raycast(transform.position, -Vector2.up);
		RaycastHit2D hitDown = Physics2D.Raycast(transform.position, -Vector2.down);
		RaycastHit2D hitLeft = Physics2D.Raycast(transform.position, -Vector2.left);
		RaycastHit2D hitRight = Physics2D.Raycast(transform.position, -Vector2.right);

		if(collider !=null) 
		{
			if (Input.GetKey(KeyCode.A) && hitLeft.distance > 1)
			{
				transform.position += Vector3.left * speed * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.D) && hitRight.distance > 1)
			{
				transform.position += Vector3.right * speed * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.W) && hitUp.distance > 1)
			{
				transform.position += Vector3.up * speed * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.S) && hitDown.distance > 1)
			{
				transform.position += Vector3.down * speed * Time.deltaTime;
			}
		}
		else
		{
			if (Input.GetKey(KeyCode.J) && hitLeft.distance > 1)
			{
				transform.position += Vector3.left * speed * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.L) && hitRight.distance > 1)
			{
				transform.position += Vector3.right * speed * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.I) && hitUp.distance > 1)
			{
				transform.position += Vector3.up * speed * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.K) && hitDown.distance > 1)
			{
				transform.position += Vector3.down * speed * Time.deltaTime;
			}
		}
	}
}
*/