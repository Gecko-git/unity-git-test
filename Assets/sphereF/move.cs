using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class move : MonoBehaviour {
	
	public float speed = 3.0F;

	private Vector3 moveDirection;
	private CharacterController controller;
	public float gravity = 10f;

	private float rotationSpeed=5f;
	private float deltaTimeSpeed = 0.5F;
	private bool speedFlag= true;

	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	void Update () {
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

		if (controller.isGrounded) moveDirection = transform.transform.forward * speed * 1;
		else moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);

	}

	void speedChange(bool sF,float dTS){					//速度変化関数
		if (sF == true) {
			dTS -= Time.deltaTime*20;
		} else {
			dTS += Time.deltaTime*30;
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
