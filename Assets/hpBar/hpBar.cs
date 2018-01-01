using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class hpBar : MonoBehaviour {

	Slider slider;

	void Start () {
		slider = GameObject.Find("Slider2").GetComponent<Slider>();
	}

	float _hp = 0;
	void Update () {
		_hp = move.hp;

		// HPゲージに値を設定
		slider.value = _hp;
	}
}
