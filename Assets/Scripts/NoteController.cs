using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteController : MonoBehaviour {

	private float speed = 2f;

    void Update() {
        this.transform.Translate(new Vector3(0, 0, -speed) * Time.deltaTime);
    }

}
