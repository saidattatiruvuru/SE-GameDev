using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{

    public Canvas MenuPage , Collection;
    public TextMeshProUGUI score;
    int n;

    void OnStart()
    {
        score = GetComponent<TextMeshProUGUI>();
        MenuPage = GetComponent<Canvas>();
        Collection = GetComponent<Canvas>();
    }

    void Start()
    {
        
        Debug.Log("on start!!!!");

        if (PlayerPrefs.HasKey("HomePage") && PlayerPrefs.GetString("HomePage") =="Collection")
        {
            Debug.Log("COLLECTION");
            MenuPage.enabled = false;
            Collection.enabled = true;
        }

        else
        {
            MenuPage.enabled = true;
            Collection.enabled = false;
        }

        if(PlayerPrefs.HasKey("Score"))
        {
            Debug.Log("SCORE");
            Debug.Log(PlayerPrefs.GetInt("Score"));
            score.text = PlayerPrefs.GetInt("Score").ToString();
        }

        PlayerPrefs.SetString("HomePage", "MainMenu");
    }

    public void PlayGame()
    {
        if (!PlayerPrefs.HasKey("MaxLevel"))
        {
            PlayerPrefs.SetInt("MaxLevel", 1);
            n = 1;
        }

        else
        {
            n = PlayerPrefs.GetInt("MaxLevel");
        }

        if (n <= 5)
        SceneManager.LoadScene(n+1);
        else 
        SceneManager.LoadScene(6);
    }
}
