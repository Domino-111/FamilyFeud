using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public List<Question> questions;

    [ContextMenu("Save Game")]
    public void SaveGame()
    {
        SavedData savedData = new SavedData();

        foreach (Question q in questions)
        {
            savedData.questions.Add(q);
        }

        JSON_Manager.SaveToJson(savedData);
    }

    [ContextMenu("Load Game")]
    public void LoadGame()
    {
        SavedData newData = JSON_Manager.LoadFromJson();
        questions.Clear();
        foreach (Question q in newData.questions)
        {
            questions.Add(q);
        }
    }
}

[System.Serializable]
public class Question
{
    public string question;

    public List<string> responses = new List<string>();
}
