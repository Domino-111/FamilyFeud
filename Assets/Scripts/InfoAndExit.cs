using UnityEngine;

public class InfoAndExit : MonoBehaviour
{
    public GameObject gamePanel;
    public GameObject infoPanel;

    private void Awake()
    {
        infoPanel.SetActive(false);
        gamePanel.SetActive(true);
    }

    public void Info()
    {
        infoPanel.SetActive(true);
        gamePanel.SetActive(false);
    }

    public void Return()
    {
        infoPanel.SetActive(false);
        gamePanel.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exited the questionnaire");
    }
}
