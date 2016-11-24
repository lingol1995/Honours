using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {

    bool paused;
    bool inventoryOn;
    public GameObject menu;
    public GameObject inventoryMenu;

	// Use this for initialization
	void Start () {
        paused = false;
        inventoryOn = false;
        menu.SetActive(false);
        inventoryMenu.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        if (paused == false)
        {
            Time.timeScale = 1;
            menu.SetActive(false);
            if (Input.GetKey(KeyCode.P))
            {
                //Debug.Log("unpause");
                paused = true;
            }
        }

        if (paused == true)
        {
           // Debug.Log("Paused");
            Time.timeScale = 0;
            if (inventoryOn == false)
                menu.SetActive(true);
            else
                menu.SetActive(false);
        }


	}

    public void play()
    {
        
        paused = false;
    }

    public void inventory()
    {
        inventoryOn = true;
        Time.timeScale = 0;
        inventoryMenu.SetActive(true);
        
    }

}
