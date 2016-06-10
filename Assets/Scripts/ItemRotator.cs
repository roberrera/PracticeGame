using UnityEngine;
using System.Collections;

public class ItemRotator : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Rotate the object on the x, y, z axes
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}
}
