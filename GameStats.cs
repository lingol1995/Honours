using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameStats : MonoBehaviour
{
    // Use this for initialization
    public GameObject player;
    public Camera main;
    public Camera sceneCam;

    public static GameStats control;

    public enum GameState { normal, scene, job1, job2, job3 };
    public enum ColourChoice { none, blue, red, green };

    public float health;

    public float score;
    public float money;

    public Slider healthbar;
    public GameState currState;
    public ColourChoice colour;

    bool blue, red, green;
    bool level1, level2;

    public Text text;
    public Text moneyText;

    void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }

        else if (control != this)
        {
            Destroy(gameObject);
        }

        health = 50.0f;



    }

    void Start()
    {
        sceneCam.enabled = false;
        sceneCam.gameObject.SetActive(false);
        moneyText.text = "" + money;
        text.text = " " + score;
        currState = GameState.normal;
        colour = ColourChoice.none;
        blue = false;
        green = false;
        red = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (level1 == true)
        {
            text.text = " " + score;
            moneyText.text = "" + money;

            healthbar.value = health / 100;

            if (score >= 20)
            {
                money += 10;
            }
        }

        switch (colour)
        {
            case ColourChoice.none: break;
            case ColourChoice.blue: blue = true; level2 = true; level1 = false; break;
            case ColourChoice.red: red = true; level2 = true; level1 = false; break;
            case ColourChoice.green: green = true; level2 = true; level1 = false; break;
        }

        if (level1 == true)
        {
            switch (currState)
            {
                case GameState.scene:
                    sceneCam.enabled = true;
                    main.enabled = false;
                    sceneCam.gameObject.SetActive(true);
                    main.gameObject.SetActive(false);


                    player.SetActive(false);


                    if (Input.GetKey(KeyCode.L))
                    {
                        currState = GameState.normal;
                    }
                    break;

                case GameState.normal: sceneCam.enabled = false;
                    sceneCam.gameObject.SetActive(false);
                    main.enabled = true;


                    player.SetActive(true);
                    main.gameObject.SetActive(true);

                    if (Input.GetKey(KeyCode.L))
                    {
                        currState = GameState.scene;
                    }
                    break;
            }
        }

    }
}    
