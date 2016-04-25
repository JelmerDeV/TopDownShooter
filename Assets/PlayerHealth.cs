using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
	public float playerHealth = 100;
	public Text healthText;
	public Text scoreText;
	public float score = 0;
	// Use this for initialization

	void Awake()
	{
	//	healthText = GetComponent<Text> ();
	}

	void Start () {
		UpdateUI ();
	}

	void Update(){

		UpdateUI ();

		if (playerHealth == 0 || playerHealth < 0) {
			Destroy (gameObject);
		}



	}
	

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag ("Enemy")) 
		{
			playerHealth -= 10;

		}
	}

	void UpdateUI()
	{
		healthText.text = "Health: "+ playerHealth;
		//scoreText.text = " Score: " + score;
	}


}
