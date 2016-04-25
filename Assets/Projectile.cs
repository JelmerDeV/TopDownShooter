using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	private float _speed;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 5f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * _speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Enemy" || other.tag == "Wall") {
			Destroy (gameObject, 0f);
		}


	}

	public void SetSpeed(float value) {
		_speed = value;
	}
}
