using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PickUpCount : MonoBehaviour {

    Text score ;
    PlayerController player1;

    void Start() {
        score = this.gameObject.GetComponent<Text>();
        player1 = GameObject.Find("Player").GetComponent<PlayerController>();
    }

	// Update is called once per frame
	void Update () {
        score.text = "Score: " + player1.count;
	}
}
