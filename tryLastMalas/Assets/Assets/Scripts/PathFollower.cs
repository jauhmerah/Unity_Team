using UnityEngine;
using System.Collections;

public class PathFollower : MonoBehaviour {
	
	public Transform[] path;
	public float speed = 5.0f;
	public float reachDist = 1.0f;
	public int currentPoint = 0;
	
	void Start (){
	}
	void Update (){
		Vector3 dir = path [currentPoint].position - transform.position;
		transform.position += dir * Time.deltaTime * speed;
		if ( dir.magnitude <= reachDist)
		{
			currentPoint++;
		}
		if (currentPoint >= path.Length)
		{
			currentPoint = 0;
		}
	}
	
	void OnDrawGizmos()
	{
		for ( int i = 0; i < path.Length; i++) {
			if (path[i]  !=null) {
				Gizmos.DrawSphere(path[i].position,reachDist);
			}
		}
	}
}