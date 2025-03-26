using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Questionnaire : MonoBehaviour
{
    public TextAsset textFile;

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exited the questionnaire");
    }
}
