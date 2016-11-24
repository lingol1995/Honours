using UnityEngine;
using System.Collections;
////NEED TO DO:
//tell when animation is finished
//switch back to player
//Switch back to scene after trigger hit
//Text
//Charcter Animations

public class Scene : MonoBehaviour {

    public Camera cam1;
    public Camera cam2;
   // public GameObject player;
 

    private Animator camAnim;

    private Animator sceneAnim;

    public string animation;

	// Use this for initialization
	void Start () {
        cam1.enabled = true;
        cam1.gameObject.SetActive(true);
        cam2.gameObject.SetActive(false);
        cam2.enabled = false;

        sceneAnim = GetComponent<Animator>();
        camAnim = cam1.GetComponent<Animator>();

        
	}
	
	// Update is called once per frame
	void Update () {

        

        sceneAnim.SetBool(animation, true);

	}
}
