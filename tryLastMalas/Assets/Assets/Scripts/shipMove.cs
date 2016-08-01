using UnityEngine;
using System.Collections;

public class shipMove : MonoBehaviour{
	public float rotSpeed = 180f;
	public float shipSpeed;
	//public float maxPost;
	Vector3 position;

	
	void Start(){
		position = transform.position;
	}
	
	void Update (){
		// ROTATE the ship.
		
		// Grab our rotation quaternion
		Quaternion rot = transform.rotation;
		
		// Grab the Z euler angle
		float z = rot.eulerAngles.z;
		
		// Change the Z angle based on input
		z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
		
		// Recreate the quaternion
		rot = Quaternion.Euler( 0, 0, z );
		
		// Feed the quaternion into our rotation
		transform.rotation = rot;
		position.x += Input.GetAxis ("Horizontal") * shipSpeed * Time.deltaTime;
		transform.position = position;
		position.y += Input.GetAxis ("Vertical") * shipSpeed * Time.deltaTime;
		transform.position = position;
		//position.x = Mathf.Clamp (position.x, -2.2f,2.2f);
		//transform.position = position;
		//position.y = Mathf.Clamp (position.y, -2.07f,4.5f);
		//transform.position = position;
	}
	void OnCollisionEnter(Collision col2)
	{
		if (col2.gameObject.tag == "meteor")
		{
			Destroy (col2.gameObject);
		}
	}
}