using UnityEngine;
using System.Collections;

public class TextControl : MonoBehaviour
{


	void OnMouseEnter()
	{

		gameObject.GetComponent<Renderer>().material.color = Color.black;

	}
	void OnMouseExit()
	{
		gameObject.GetComponent<Renderer>().material.color = Color.white;
	}
}﻿