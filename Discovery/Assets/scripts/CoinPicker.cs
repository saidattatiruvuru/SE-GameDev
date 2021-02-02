using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPicker : MonoBehaviour
{

    private float coin = 0;

    public TextMeshProUGUI score;

    void OnStart()
    {
        score = GetComponent<TextMeshProUGUI>();
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
    }
}
