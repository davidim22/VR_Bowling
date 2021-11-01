using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Bowl bowl;
    public TextMesh infoText;
    public Pin[] pins;
    // after pin falls
    public float evaluationTime = 10f;
    private float gameTimer = 0f;
    private bool evaluating = false;
    void Start()
    {
        
    }

    void Update()
    {
        infoText.text = "Throw the\nbowling ball!";
        if (evaluating == false)
        {
            if (bowl.pin_fall == true)
            {
                evaluating = true;
                gameTimer = evaluationTime;
            }
        }else{
            gameTimer -= Time.deltaTime;
            if (gameTimer <= 0f)
            {
                int score = 0;
                for (int i = 0; i < pins.Length; i++)
                {
                    if (pins[i] == null)
                    {
                        score++;
                    }
                }
                infoText.text = "Your score\n" + score + "/6";
            }
            if (gameTimer <= -3f)
            {
                SceneManager.LoadScene (SceneManager.GetActiveScene().name);
            }
        }
    }
}
