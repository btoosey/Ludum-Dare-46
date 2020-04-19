using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public GameObject canvasGame;
    public GameObject canvasLose;
    public GameObject canvasWin;

    public void GameOver ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            ShowLoseCanvas();
        }
    }

    void ShowLoseCanvas()
    {
        canvasGame.SetActive(false);
        canvasLose.SetActive(true);
    }

    public void Win()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            ShowWinCanvas();
        }
    }

    void ShowWinCanvas()
    {
        canvasGame.SetActive(false);
        canvasWin.SetActive(true);
    }
}
