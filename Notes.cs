using UnityEngine;
using System.Collections;


public class Notes : MonoBehaviour {

    enum colour {none, green, pink, yellow };
    bool noteEntered;

    float score;

    bool green;
    bool pink;
    bool yellow;

    float speed;

    colour Colour;
	// Use this for initialization
	void Start () {

        Colour = colour.none;

        noteEntered = false;

        //green = false;
        //pink = false;
       // yellow = false;

        RandomSpeed();
	}
	
	// Update is called once per frame
	void Update () {
    //Debug.Log("entered" + rightOne);
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        //transform.parent.gameObject.transform.Translate(Vector3.down * Time.deltaTime);

        switch (Colour.ToString())
        {
            case "none": break;
            

            case "pink": if (Input.GetKeyDown(KeyCode.S))
                {
                    GameStats.control.score++;
                    //GameStats.control.money++;

                }; break;

            case "green": if (Input.GetKeyDown(KeyCode.D))
                {
                    GameStats.control.score++;
                    //GameStats.control.money++;
                };
                break;

            case "yellow": if (Input.GetKeyDown(KeyCode.A))
                {
                    GameStats.control.score++;
                    //GameStats.control.money++;
                } break;

            default: break;

        }

      
	}

    public void OnTriggerEnter(Collider collide)
    { 
        if (collide.gameObject.tag == "HitPink")
            {

                Colour = colour.pink;
                Debug.Log("HITPINK");
            }

            if (collide.gameObject.tag == "HitGreen")
            {
                Colour = colour.green;
              
            }
            
    

           
            


            if (collide.gameObject.tag == "HitYellow")
            {
                Debug.Log("HITyellow");
                Colour = colour.yellow;

            }
            

            
            
        }

    public void OnCollisionEnter(Collision collide)
    {
         if (collide.gameObject.tag == "Ground")
         {
           
            Destroy(gameObject);

        }
    }

    void RandomSpeed()
    {
        speed = Random.Range(0.5F, 3);
    }
       


}
