using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleDetector : MonoBehaviour
{
    public PlayerMovement player;
    public Canvas deadCanvas;
    public GameObject Firepanel, Smokepanel, Acidpanel, Lightningpanel;
    bool isAlive = true;

    void OnStart()
    {
        deadCanvas = GetComponent<Canvas>();
        deadCanvas.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 9 && isAlive)
        {
            Firepanel.SetActive(false);
            Acidpanel.SetActive(false);
            Smokepanel.SetActive(false);
            Lightningpanel.SetActive(false);
            player.Dead();
            Debug.Log("dead");
            deadCanvas.gameObject.SetActive(true);
            if(other.transform.tag == "Fire")
            {
               Firepanel.SetActive(true);
            }
            else if(other.transform.tag == "Lightning")
            {
                Lightningpanel.SetActive(true);
            }
            else if(other.transform.tag == "Smoke")
            {
                Smokepanel.SetActive(true);
            }
            else if(other.transform.tag == "Acid")
            {
                Acidpanel.SetActive(true);
            }
            isAlive = false;
        }
    }
}
