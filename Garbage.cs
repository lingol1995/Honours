using UnityEngine;
using System.Collections;

public class Garbage : MonoBehaviour {

    public GameObject lid;

     float smooth = 5.0f;
     float DoorOpenAngle = 25.0f;
     float DoorCloseAngle = 45.0f;
     bool open;
     bool enter;
	// Use this for initialization
	void Start () {
        open = false;
	}
	
	// Update is called once per frame
    void Update()
    {
        if (open == true)
        {
            Debug.Log("Opening");
            
            Quaternion target = Quaternion.Euler(0, 0, 25 );
            // Dampen towards the target rotation
            lid.transform.localRotation = Quaternion.Lerp(lid.transform.localRotation, target,
            Time.deltaTime * smooth);
        }

        if (open == false)
        {
            Quaternion target1 = Quaternion.Euler(DoorCloseAngle,0 , 0);
            // Dampen towards the target rotation
            lid.transform.localRotation = Quaternion.Lerp(lid.transform.localRotation, target1,
         Time.deltaTime * smooth);
        }
        

    }


	

    void OnTriggerEnter(Collider collide)
    {
        if (collide.gameObject.tag == "Player")
        {
           // Debug.Log("Garbage");
            open = true;
        }
        
    }
}
