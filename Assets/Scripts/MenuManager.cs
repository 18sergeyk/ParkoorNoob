using System;
using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
[DefaultExecutionOrder(0)]
public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private Button[] buttons;
    [SerializeField]
    public List<Level> levels = new List<Level>();
    public static List<Level> levelStatic = new List<Level>();

    public void StateScenes(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    private void Awake()
    {
        if (levelStatic.Count <= 0)
        {

            levelStatic = levels;
        }
        //SaveManager.instance.saveData.level = levelStatic;

    }
    private void Start()
    {
        Debug.Log(levelStatic.Count);
        for (int i = 1; i <= levelStatic.Count; i++)
        {
            Debug.Log(levelStatic[i - 1].isComplited);
            if (levelStatic[i - 1].isComplited)
            {
                if (buttons[i])
                {

                    buttons[i].interactable = true;
                }
            }
        }
    }



}

[Serializable]
public class Level
{
    public int level;
    public bool isComplited;
    //public Button button;
    public Level(int level, bool isComplited)
    {
        this.level = level;
        this.isComplited = isComplited;
    }
}
