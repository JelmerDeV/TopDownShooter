using UnityEngine;
using System.Collections;
using System.Collections;

public class EnemyAI : MonoBehaviour {
	public float score = 0;
	// Use this for initialization

	public float health = 3;
	/*
	public Transform target; //the enemy's target
	public float moveSpeed = 20; //move speed
	public float rotationSpeed = 3; //speed of turning
    */
	NavMeshAgent _navMeshAgent;
	GameObject _playerGameObject;

	//public Transform myTransform; //current transform data of this enemy


	void Awake()
	{
		//myTransform = transform; //cache transform data for easy access/preformance
		_navMeshAgent = GetComponent<NavMeshAgent> ();
		_playerGameObject = GameObject.FindGameObjectWithTag ("Player");
	}


	// Use this for initialization
	void Start ()
	{
		
		//target = GameObject.FindWithTag("Player").transform; //target the player
	}

	// Update is called once per frame
	void Update ()
	{


		//rotate to look at the player
		/*myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
			Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);


		//move towards the player
		myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
		*/
		Debug.Log (health);
		_navMeshAgent.SetDestination (_playerGameObject.transform.position /*+ (transform.forward * 3)*/);

		if (health == 0) {
			Destroy (gameObject, 0f);

		}
	}






	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Bullet") 
		    {
			//Destroy (gameObject, 0f);
			health --;
		    }
        
	
	}

}