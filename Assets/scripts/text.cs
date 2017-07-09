using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;


public class text : MonoBehaviour {
	public GameObject text_gameObject;
	public Text myText1;
	string newString;
	public Color newColor;
	public InputField myInput;
	Animation AnimatorComponent;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void tikla()
	{
		
		myText1.text = myInput.text;

		text_gameObject.SetActive(true);

	}
}
