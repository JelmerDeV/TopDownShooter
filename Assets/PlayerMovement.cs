using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float speed;
	private Vector3 _direction;
	private Rigidbody _rigidbody;

	// Use this for initialization
	void Awake () 
	{
	  // get reference rigidbody

		_rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	// Fetch Input
		float x = Input.GetAxisRaw("Horizontal");
		float y = Input.GetAxisRaw("Vertical");
		_direction = new Vector3 (x, 0f, y);

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		Plane plane = new Plane (Vector3.up, Vector3.zero);
		float distance;

		if (plane.Raycast (ray, out distance)) {

			Vector3 point = ray.GetPoint (distance);
			Vector3 adjustedheightPoint = new Vector3 (point.x, transform.position.y, point.z);
			transform.LookAt (adjustedheightPoint);

		}
	}

	void FixedUpdate()
	{
		// move rigidbody using MovePosition()	
		Vector3 velocity = _direction.normalized * speed * Time.fixedDeltaTime;
		_rigidbody.MovePosition(_rigidbody.position + velocity);
	}
}
