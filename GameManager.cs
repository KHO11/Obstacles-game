using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    // Update is called once per frame

    public GameObject completeLevelUI;
  

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }


    public void endGame()
    {

            gameEnded = true;
            Debug.Log("Game Over");
            restart();
        
    
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
