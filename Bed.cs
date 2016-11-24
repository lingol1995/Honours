using UnityEngine;
using System.Collections;

public class Bed : MonoBehaviour {

   // public static Bed touch;

    TextMesh words;

    public TextMesh word;
    public string message;
    public Transform player;

    TextMesh getText;
    public bool touching;

	// Use this for initialization
	void Start () {
        touching = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (touching == true)
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                Debug.Log("T Pressed");
                GameStats.control.health = 100f;
            }

            
        }
	}

    void OnTriggerEnter(Collider collide)
    {
        if (collide.gameObject.tag == "Player")
        {   
            words = (TextMesh)Instantiate(word, transform.position, player.transform.rotation);
            words.text = message;
            words.transform.LookAt(Vector3.forward);
            touching = true;

            
        }
       
    }

    void OnTriggerExit(Collider collide)
    {
        if (collide.gameObject.tag == "Player")
        {
            Destroy(words);
            touching = false;
        }
    }
}
