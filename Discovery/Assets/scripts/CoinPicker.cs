using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CoinPicker : MonoBehaviour
{
    public int LevelOrbs = 1;
    private int coin = 0;
    public int Level = 1;

    private float orb = 0;

    public TextMeshProUGUI score;
    public TextMeshProUGUI Finalscore;

    public Canvas SuccessCanvas;

    public void GoToCollection()
    {
        int finScr = 0;
        if(PlayerPrefs.HasKey("Score"))
        {
            finScr = PlayerPrefs.GetInt("Score");
        }
        finScr += coin;
        PlayerPrefs.SetInt("Score", finScr);

        if (PlayerPrefs.HasKey("MaxLevel")&& PlayerPrefs.GetInt("MaxLevel")<Level || !PlayerPrefs.HasKey("MaxLevel"))
        {
            PlayerPrefs.SetInt("MaxLevel", Level);
        }

        PlayerPrefs.SetString("HomePage", "Collection");
        SceneManager.LoadScene(0);
    }

    void OnStart()
    {
        score = GetComponent<TextMeshProUGUI>();
        SuccessCanvas = GetComponent<Canvas>();
        SuccessCanvas.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "Coin")
        {
            other.transform.tag = "Collected";
            other.gameObject.SetActive(false);
            coin++;
            Debug.Log(coin);
            score.text = coin.ToString();
        }

        else if (other.gameObject.layer == 11)
        {
            other.transform.tag = "Collected";
            other.gameObject.SetActive(false);
            orb++;
            Debug.Log("Orb");
            Debug.Log(orb);
        }

        else if (other.transform.tag == "LevelFinish")
        {
            if(orb == LevelOrbs)
            {
                SuccessCanvas.gameObject.SetActive(true);
                Finalscore.text = coin.ToString();
            }
            Debug.Log("FINISHED");
            Debug.Log(orb);
        }
    }
}
