using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class move : MonoBehaviour {
	
	public static float speed = 3.0F;
	public static float hp=10f;

	private Vector3 moveDirection;
	private CharacterController controller;
	public float gravity = 10f;

	private float rotationSpeed=5f;
	private float deltaTimeSpeed = 0.5F;
	private bool speedFlag= true;
	private float attackTime = 0f;
	public static bool attackFlag = true;

	GameObject attackField;

	void Start () {
		this.attackField = GameObject.Find("Cylinder");
		this.attackField.SetActive (false);
		controller = GetComponent<CharacterController>();
	}

	void Update () {
		
		attack ();

		if (Input.GetKey (KeyCode.LeftShift)) {
			speedFlag = true;
			rotationSpeed = 5F;
		} else {
			deltaTimeSpeed = 0;
			speedFlag = false;
			rotationSpeed = 1F;
		}
			speedChange(speedFlag,deltaTimeSpeed);
			rotation (rotationSpeed);

		moveDirection = transform.transform.forward * speed * 1 + transform.transform.up * gravity * Time.deltaTime * (-1) + transform.transform.up * speed * Input.GetAxis ("Vertical") * (-1);

		controller.Move(moveDirection * Time.deltaTime);

	}

	void attack(){		//攻撃関数
		if (attackTime == 0  && Input.GetKey (KeyCode.Z)) {
				this.attackField.SetActive (true);
				attackFlag = true;
		}

		if (attackFlag == true) {
			if (attackTime < 1) attackTime += Time.deltaTime;
			else {
				this.attackField.SetActive (false);
				attackFlag = false;
			}
		} else {
			if(attackTime > 0) attackTime -= Time.deltaTime;
			else attackTime =0;
		}
	}

	void speedChange(bool sF,float dTS){					//速度変化関数
		if (sF == true) {
			dTS -= Time.deltaTime*40;
		} else {
			dTS += Time.deltaTime*60;
		}

		speed += dTS;

		if(speed < 0)speed = 0;
		if(speed > 60F)speed = 60F;

	}

	void rotation(float rS){						//回転関数
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate (0, -rS, 0);
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (0, rS, 0);
		}
	}
}
