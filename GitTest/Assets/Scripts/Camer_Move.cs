using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camer_Move : MonoBehaviour {

    // Use this for initialization
    public float speed = 10;
    private float move_z;
    private float move_x;
    private Transform m_transform;
	void Awake () {
        m_transform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
        move_z = Input.GetAxis("Horizontal")*speed;
        move_x = Input.GetAxis("Vertical")*speed;
        m_transform.Translate(new Vector3(move_z,0,move_x)*Time.deltaTime);
	}
}
