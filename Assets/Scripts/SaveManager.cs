using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[DefaultExecutionOrder(-10)]

public class SaveManager : MonoBehaviour
{
    public static SaveManager instance;

    public SaveData saveData = new SaveData();
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            return;
        }
        Destroy(gameObject);
        //saveData = new SaveData();
    }

    public void Save()
    {
        saveData.level = MenuManager.levelStatic.ToArray();

    }

    public class SaveData
    {
        public Level[] level;
    }

}
