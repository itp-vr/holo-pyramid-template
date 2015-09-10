using UnityEngine;
using System.Collections;

public class AppSettings : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
