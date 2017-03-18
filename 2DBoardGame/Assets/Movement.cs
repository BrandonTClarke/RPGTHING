/*
using System.Collections;
using UnityEngine;

class Movement : MonoBehaviour
{
    Vector3 pos;                                // For movement
    float speed = 5.0f;                         // Speed of movement


    void Start()
    {
		
        pos = transform.position;          // Take the initial position
    }

    void FixedUpdate()
    {
		RaycastHit2D hitUp = Physics2D.Raycast(this.gameObject.transform.position, -Vector2.up, 1.0f);
		RaycastHit2D hitDown = Physics2D.Raycast(this.gameObject.transform.position, -Vector2.down, 1.0f);
		RaycastHit2D hitLeft = Physics2D.Raycast(this.gameObject.transform.position, -Vector2.left, 1.0f);
		RaycastHit2D hitRight = Physics2D.Raycast(this.gameObject.transform.position, -Vector2.right, 1.0f);

		if (Input.GetKey(KeyCode.A) && transform.position == pos)
        { // Left
            pos += Vector3.left;
			transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
        }
		if (Input.GetKey(KeyCode.D) && transform.position == pos)
        { // Right
            pos += Vector3.right;
			transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
        }
		if (Input.GetKey(KeyCode.W) && transform.position == pos)
		{ // Up
            pos += Vector3.up; 
			transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
        }
		if (Input.GetKey (KeyCode.S) && transform.position == pos) 
		{ // Down
			pos += Vector3.down; 
			transform.position = Vector2.MoveTowards (transform.position, pos, Time.deltaTime * speed);
		} 
		else {
			Debug.Log (hitLeft.collider.name); 
			Debug.Log (hitRight.collider.name); 
			Debug.Log (hitUp.collider.name); 
			Debug.Log (hitDown.collider.name); 
		}
    }
}

*/