using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<Player>())
        {
            Debug.Log("Вы выйграли");
            Debug.Log(MenuManager.levelStatic[SceneManager.GetActiveScene().buildIndex].isComplited);
            MenuManager.levelStatic[SceneManager.GetActiveScene().buildIndex].isComplited = true;
            Debug.Log(MenuManager.levelStatic[SceneManager.GetActiveScene().buildIndex].isComplited);
            SaveManager.instance.Save();
            SceneManager.LoadScene(0);
        }
    }
}
