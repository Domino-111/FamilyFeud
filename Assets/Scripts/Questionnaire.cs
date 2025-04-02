using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Questionnaire : MonoBehaviour
{
    public GameObject gamePanel;
    public GameObject infoPanel;

    public TextAsset textFile;

    private DataManager dataManager;

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

    public void DisplayQuestion()
    {
        //dataManager.questions = textFile.text.Split('\n');
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exited the questionnaire");
    }
}
