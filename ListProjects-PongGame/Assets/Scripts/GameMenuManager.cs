using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuManager : MonoBehaviour
{
    [SerializeField] GameManager gm;

    public void ResumeGame()
    {
        gm.MenuHandler();
    }

    public void EndGame()
    {
        SceneManager.LoadScene(0);
    }
}
