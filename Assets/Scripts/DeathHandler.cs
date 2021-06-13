using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;
    [SerializeField] TextMeshProUGUI canvasText;
    bool gameOver = false;

    void Start()
    {
        gameOverCanvas.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || (Input.GetKeyDown(KeyCode.P)))
        {
            if(!gameOver)
            {
                if(gameOverCanvas.enabled)
                {
                    ContinueGame();
                }
                else
                {
                    PauseGame();
                }
            }
        }
    }

    public void HandleDeath()
    {
        gameOverCanvas.enabled = true;
        Time.timeScale = 0;
        FindObjectOfType<WeaponSwither>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        canvasText.text = $"skurili su te";
        gameOver = true;
    }

    public void HandleLevel()
    {
        //gameOverCanvas.enabled = true;
        //Time.timeScale = 0;
        //FindObjectOfType<WeaponSwither>().enabled = false;
        //Cursor.lockState = CursorLockMode.None;
        //Cursor.visible = true;
        //canvasText.text = $"završio si ovu razinu";
        //gameOver = true;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;
    }

    private void PauseGame()
    {
        gameOverCanvas.enabled = true;
        canvasText.text = $"ajmo dalje";
        Time.timeScale = 0;
    }
    private void ContinueGame()
    {
        gameOverCanvas.enabled = false;
        Time.timeScale = 1;
    }
}
