using UnityEngine;
using System.Collections;

public class Busking : MonoBehaviour {

    float time;
    float createNoteTime;
    int random;

    public GameObject[] notes;
    GameObject createdNote;
   // public GameObject green;
   // public GameObject yellow;

    int repeat;
    public GameObject pinkCorr;
    public GameObject greenCorr;
    public GameObject yellowCorr;

    
    public GameObject[] Pos;
    
	// Use this for initialization
	void Start () {
        RandomTime();
        time = 0;
        repeat = 0;
    
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;

        if (time >= createNoteTime)
        {
            SpawnNote();
            RandomTime();
            repeat++;
        }

        //else GameStats.control.currState = GameStats.GameState.normal;

        //MoveNote();
	}

    void RandomTime()
    {
        createNoteTime = Random.Range(1, 3);
    }

    void SpawnNote()
    {
        
        time = 0;
        random = Random.Range(0, 3);

        createdNote = (GameObject)Instantiate(notes[random], Pos[random].transform.position, notes[random].transform.rotation);
        //createdNote.transform.localScale = new Vector2(0.8f, 0.5f);
        
    }

    void MoveNote()
    {
        createdNote.transform.Translate(Vector3.down * Time.deltaTime);
    }

    public void back()
    {
        GameStats.control.currState = GameStats.GameState.normal;
    }
}
