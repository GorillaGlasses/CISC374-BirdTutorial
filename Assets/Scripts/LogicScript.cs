using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public GameObject scoreText;
    public GameObject gameOverScreen;
    public GameObject highScoreText;
    public GameObject titleScreen;
    public GameObject bird;
    public GameObject pipeSpawner;
    public GameObject bottom;
    
    public void addScore(int addedScore){
        playerScore += addedScore;
        scoreText.GetComponentInChildren<Text>().text = "Score: " + playerScore.ToString();
    }

    public void startGame(){
        titleScreen.SetActive(false);
        bird.SetActive(true);
        pipeSpawner.SetActive(true);
        bottom.SetActive(true);
        scoreText.SetActive(true);
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver(){
        gameOverScreen.SetActive(true);
        if(!PlayerPrefs.HasKey("High Score")){
            PlayerPrefs.SetInt("High Score", playerScore);
        }else if(playerScore > PlayerPrefs.GetInt("High Score")){
            PlayerPrefs.SetInt("High Score", playerScore);
        } 
        highScoreText.GetComponentInChildren<Text>().text = "High Score: " + PlayerPrefs.GetInt("High Score");
        highScoreText.SetActive(true);
    }

}
