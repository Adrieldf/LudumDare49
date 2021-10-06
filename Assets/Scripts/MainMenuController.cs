using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField]
    private GameObject loreMenu;

    private void Start()
    {
        loreMenu.SetActive(false);
    }
    public void onStartClick()
    {
        SceneManager.LoadScene("Game");
    }
    public void onLoreClick()
    {
        loreMenu.SetActive(true);
    }
    public void onExitClick()
    {
        Application.Quit();
    }
}
