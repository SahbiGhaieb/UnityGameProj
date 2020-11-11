using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;
    public Rigidbody rb;
    public int position = 0; //0 mid 1 left 2 right
    // Start is called before the first frame update
    void Start () {
        rb = GetComponent<Rigidbody> ();
    }

    // Update is called once per frame
    public GameObject ball;
    void Update () {
        //auto move
        ball.GetComponent<Rigidbody> ().AddForce (Vector3.forward * speed);
        if (position == 0) {
            if (Input.GetKeyDown (KeyCode.LeftArrow)) {
                position = 1;
                Debug.Log ("Left Arrow key was pressed.");
                transform.position = new Vector3( -3, this.transform.position.y, this.transform.position.z);
                
            }
            if (Input.GetKeyDown (KeyCode.RightArrow)) {
                position = 2;
                Debug.Log ("Right Arrow key was pressed.");
                transform.position = new Vector3( 3, this.transform.position.y, this.transform.position.z);
            }
        }
        if (position == 1) {
            if (Input.GetKeyDown (KeyCode.RightArrow)) {
                position = 0;
                Debug.Log ("Right Arrow key was pressed.");
                transform.position = new Vector3( 0.5f, this.transform.position.y, this.transform.position.z);
            }
        }
        if (position == 2) {
            if (Input.GetKeyDown (KeyCode.LeftArrow)) {
                position = 0;
                Debug.Log ("Left Arrow key was pressed.");
                transform.position = new Vector3( 0.5f, this.transform.position.y, this.transform.position.z);
                
            }
        }

    }
}