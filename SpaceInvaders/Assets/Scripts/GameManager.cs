using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int lives = 3;
    public static bool playGame;

    public Text livesText;
    public Text endText;

    // Start is called before the first frame update
    void Start()
    {
        livesText.text = "Lives: " + lives;
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = "Lives: " + lives;
        if(lives == 0)
        {
            endText.text = "You Lose!!!";
        }
    }
}
