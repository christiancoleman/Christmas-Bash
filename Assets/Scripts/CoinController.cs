using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player One");
        print("player = " + player);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter() {
        Destroy(gameObject);
        //player.GetComponent<ThirdPersonCharacter>().Score = 1;
        //GetComponent<
    }
}
