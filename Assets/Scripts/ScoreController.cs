using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreController : MonoBehaviour
{
    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;
    public GameObject scoreTextPlayer1;
    public GameObject scoreTextPlayer2;
    public int goalScoresToWin;

    public void GoalPlayer1()
    {
        this.scorePlayer1++;
        this.scoreTextPlayer1.GetComponent<Text>().text = this.scorePlayer1.ToString();
        if(this.scorePlayer1 >= goalScoresToWin)
        {
            SceneManager.LoadScene("GameOverPlayer1Won");
        }
    }
    public void GoalPlayer2()
    {
        this.scorePlayer2++;
        this.scoreTextPlayer2.GetComponent<Text>().text = this.scorePlayer2.ToString();
        if (this.scorePlayer2 >= goalScoresToWin)
        {
            SceneManager.LoadScene("GameOverPlayer2Won");
        }
    }

}
