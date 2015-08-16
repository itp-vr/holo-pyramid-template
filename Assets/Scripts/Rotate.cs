using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	public float rotX = 0.1f;
	public float rotY = 0.15f;
	public float rotZ = 2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(rotX, rotY, rotZ);
	}
}
