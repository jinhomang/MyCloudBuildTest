using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

#if MY_CLOCKWISE
	int speed = -270; 
#else
	int speed = 270; 
#endif

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.forward, speed*Time.deltaTime);
	}
}
