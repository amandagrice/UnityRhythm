using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitZoneController : MonoBehaviour {

	public KeyCode key;
	private Vector3 originalPosition;

    void Start() {
        originalPosition = this.transform.position;
    }

    void Update() {
    	if (Input.GetKey(key)) {
    		if (this.transform.position.y > 0) {
            	this.transform.position += Vector3.down * Time.deltaTime;
    		}
        } else {
        	this.transform.position = originalPosition;
        }
    }
}
