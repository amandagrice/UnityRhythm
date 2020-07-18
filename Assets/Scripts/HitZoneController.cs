using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitZoneController : MonoBehaviour {

	public KeyCode key;
	private Vector3 originalPosition;
	private GameObject collidedItem;

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

        if (Input.GetKeyDown(key)) {
        	if (collidedItem) {
    			print("SUCCESS");
    			Destroy(collidedItem);
    		} else {
    			print("MISSED NOTE");
    		}
        }
    }

    void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag("Note")) {
			collidedItem = other.gameObject;
		}
    }

    void OnTriggerExit() {
    	if (collidedItem) {
    		Destroy(collidedItem);
    		collidedItem = null;
    		print("MISSED NOTE");
    	}
    }

}
