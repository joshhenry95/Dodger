using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Collide : MonoBehaviour {

    public Text Lives;
    public Text Score;
    public Text Highscore;
    int lives = 10;
    int score = 0;
    int highScore = 0;
    

    void Start()
    {
        
        Lives.text = "Lives: " + lives;
        Score.text = "Score: 0";
        Highscore.text = "Highscore: 0";
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);

            // Decrement lives cnt
            lives--;

            Lives.text = "Lives: " + lives.ToString();

            /* The EditorUtility.DisplayDialog is only usable in the editor.
               Therefore, with this dialog, the game can't be built. */
            if (lives == -1)
            {
                bool retry = EditorUtility.DisplayDialog("Game Over", "You have run out of lives! You have a highscore of " + 
                    highScore + ", and scored " + score + "this round." +
                    " Would you like to retry?",
                    "Yes", "No");

                if (retry)
                {
                    lives = 10;
                    score = 0;
                    Lives.text = "Lives: " + lives;
                    Score.text = "Score: 0";
                } else
                {
                    Application.Quit();
                }
            }

        }

        if (other.gameObject.tag == "Point")
        {
            Destroy(other.gameObject);

            score++;

            Score.text = "Score: " + score.ToString();

            if (score > highScore)
            {
                highScore = score;
                Highscore.text = "Highscore: " + highScore.ToString();
            }

        }
    }

}
