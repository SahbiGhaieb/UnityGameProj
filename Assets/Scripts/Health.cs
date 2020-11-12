using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {
    public bool isAlive = true;
    public int maxHealth = 3;
    public Text currentHealthLabel;
    public Text currentScoreLabel;
    private int currentHealth;
    private int currentScore;
    // Start is called before the first frame update
    void Start () {
        currentHealth = maxHealth;
        currentScore = 0;
        UpdateGUI ();
    }

    void UpdateGUI () {
        currentHealthLabel.text = "Lives " + currentHealth.ToString ();
        currentScoreLabel.text = "Score " + currentScore.ToString ();
    }

    public void AlterHealth () {
        currentHealth--;
        UpdateGUI ();
    }
    public void AlterScore () {
        currentScore +=10;
        UpdateGUI ();
    }
    // Update is called once per frame
    void Update () {
        if (!isAlive) {
            Application.Quit ();
            gameObject.SetActive (false);
        }
        if (isAlive && currentHealth == 0) {
            Debug.Log ("DEAD");
            isAlive = false;
        }
    }

    void OnCollisionEnter (Collision collision) {

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.CompareTag ("Obstacles")) {
            AlterHealth ();
        }
        if (collision.gameObject.CompareTag ("Collectibles")) {
            AlterScore ();
            Destroy(gameObject);
        }
    }

}