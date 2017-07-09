using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
	public float speed=-5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame

	void OnTriggerEnter(Collider temas)
	{
		if (temas.gameObject.tag == "tetik")
		{
			speed = -1 * speed;
			Debug.Log ("dokundu");
		}
			
	}
	void Update () {
		transform.position += new Vector3 (speed, 0, 0);
	}
}
