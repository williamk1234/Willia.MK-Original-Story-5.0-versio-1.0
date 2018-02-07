using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

	private GameObject character;
	private ButtonController bLeft;
	private ButtonController bRight;
	private ButtonController bUp;
	private ButtonController bDown;
	public float characterSpeed;

	// Use this for initialization
	void Start ()
	{
		characterSpeed = 8;
		character = GameObject.Find ("PlayerCharacter");
		bLeft = GameObject.Find ("ArrowLeft").GetComponent<ButtonController> ();
		bRight = GameObject.Find ("ArrowRight").GetComponent<ButtonController> ();
		bUp = GameObject.Find ("ArrowUp").GetComponent<ButtonController> ();
		bDown = GameObject.Find ("ArrowDown").GetComponent<ButtonController> ();
		//ball.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (1f, 3f));
	}

	// Update is called once per frame
	void Update ()
	{
		if (bLeft.GetButtonPressed () || Input.GetKey(KeyCode.LeftArrow)) {
			character.transform.Translate (-0.01f * characterSpeed, 0, 0);
		}
		if (bRight.GetButtonPressed ()|| Input.GetKey(KeyCode.RightArrow)) {
			character.transform.Translate (0.01f * characterSpeed, 0, 0);
		}
		if (bUp.GetButtonPressed ()|| Input.GetKey(KeyCode.UpArrow)) {
			character.transform.Translate (0, 0.01f * characterSpeed, 0);
		}
		if (bDown.GetButtonPressed ()|| Input.GetKey(KeyCode.DownArrow)) {
			character.transform.Translate (0, -0.01f * characterSpeed, 0);
		}
	}
}