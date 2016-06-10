using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText;

	private int count;

	// Use this for initialization
	void Start () {
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	// Called per frame, before performing physics

	void FixedUpdate(){ // Called when performing physics actions
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); // new Vector3(x, y, z)

		transform.Translate (movement * Time.deltaTime * speed);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Collectible")) {
			other.gameObject.SetActive (false); // Bad practice if you use a ton of objects because everything stays in memory.
			count = count + 1;
			SetCountText ();
		}
	}

	void SetCountText(){
		countText.text = "Count: " + count.ToString ();
		if (count >= 12) {
			winText.text = "You Wini!";
		}
	}
}
