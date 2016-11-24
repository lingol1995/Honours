using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Inventory_Selecter : MonoBehaviour {

    public GameObject[] items;
    public Text[] numb;

    int itemNo;
    int number, number2, number3;

    public GameObject selector;

    Vector3 pos;
	// Use this for initialization
	void Start () {
        itemNo = 1;
         number = 0;
         number2 = 0;
         number3 = 0;

       

	}
	
	// Update is called once per frame
	void Update () {
 
        numb[0].text = "Amount : " + number;
        numb[1].text = "Amount : " + number2;
        numb[2].text = "Amount : " + number3;
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (itemNo > 0)
            {
                selector.transform.position = items[itemNo - 1].transform.position;
                itemNo -= 1;
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (itemNo < 2)
            {
                selector.transform.position = items[itemNo + 1].transform.position;
                itemNo += 1;
            }
        }


	}


    public void UseItem()
    {
        if (itemNo == 0 && number>=-1)      //sticks
        {
            number -= 1;
        }

        if (itemNo == 1 && number2 >= -1)       //food
        {
            number2 -= 1;
        }
        
        if (itemNo == 2 && number3 >= -1)       //flashlight
        {
            number3 -= 1;
        }


    }
}
