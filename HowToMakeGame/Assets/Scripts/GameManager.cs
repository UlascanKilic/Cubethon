using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Score score;
    public Text scoreText;
    bool isGameEnd = false;
    public float restartDelay = 1f;
    public GameObject CompleteLevelUI;

    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
        Debug.Log("Level Won!");
    }
    public void EndGame()
    {
        if(isGameEnd == false)
        {
            isGameEnd = true;
            score.enabled = false;
            scoreText.text = "Oyun bitti aslan";
            Invoke("Restart", restartDelay);
           
        }
       
    }
     void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
