using UnityEngine;
using System.Collections;

public class Jobs : MonoBehaviour {

    public GameObject player;
    public Transform Job1Position;
    public Transform Job2Position;

    public Camera cam1;
    public Camera cam2;

    public GameObject violinScreen;
    public GameObject button;

	// Use this for initialization
	void Start () {
        cam1.enabled = true;
        cam2.gameObject.SetActive(false);
        cam2.enabled = false;
        violinScreen.SetActive(false);
        button.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.GetComponent<Bed>().touching)//will check if true
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                GameStats.control.score = 0;
                GameStats.control.currState = GameStats.GameState.job1;
                Debug.Log("Add Scene");
                cam1.enabled = false;
                cam2.enabled = true;
                cam1.gameObject.SetActive(false);
                cam2.gameObject.SetActive(true);
                player.transform.position = Job1Position.position;
                player.transform.Rotate(new Vector3(0, 1, 0), 225);
                violinScreen.SetActive(true);
                button.SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.C))
            {
                GameStats.control.score = 0;
                
                GameStats.control.currState = GameStats.GameState.job2;
                cam1.enabled = true;
                cam2.enabled = false;

                cam1.gameObject.SetActive(true);
                cam2.gameObject.SetActive(false);

                player.transform.position = Job2Position.position;
                player.transform.rotation = Job2Position.rotation;
            }
        }

        switch (GameStats.control.currState.ToString())
        {
            case "normal":

                cam1.enabled = true;
                cam2.enabled = false;
                cam1.gameObject.SetActive(true);
                cam2.gameObject.SetActive(false);
                violinScreen.SetActive(false);
                button.SetActive(false);

                break;
           
        }


	}
}
