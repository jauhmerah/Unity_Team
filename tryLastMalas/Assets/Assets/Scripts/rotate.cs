using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);
		transform.Rotate(0,20*Time.deltaTime,0);
	}
}
