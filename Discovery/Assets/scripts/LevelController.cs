using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public GameObject Lev1;
    public GameObject Lev2;
    public GameObject Lev3;
    public GameObject Lev4;
    public GameObject Lev5;
    public GameObject Lev6;

    public GameObject OrbLev1;
    public GameObject OrbLev2;
    public GameObject OrbLev3;
    public GameObject OrbLev4;
    public GameObject OrbLev5;
    public GameObject OrbLev6;

    private int n = 0;

    public void ToLev1()
    {
        SceneManager.LoadScene(1);
    }

    public void ToLev2()
    {
        SceneManager.LoadScene(2);
    }

    public void ToLev3()
    {
        SceneManager.LoadScene(3);
    }

    public void ToLev4()
    {
        SceneManager.LoadScene(4);
    }

    public void ToLev5()
    {
        SceneManager.LoadScene(5);
    }

    public void ToLev6()
    {
        SceneManager.LoadScene(6);
    }

    void OnStart()
    {
        Debug.Log("OnStart!!!!!");
    }


    void Start()
    {
        Debug.Log("Start!!!!!");
        //PlayerPrefs.SetInt("MaxLevel", 0);
        //PlayerPrefs.SetInt("Score", 0);
        
        if (!PlayerPrefs.HasKey("MaxLevel"))
        {
            PlayerPrefs.SetInt("MaxLevel", 0);
        }

        else
        {
            n = PlayerPrefs.GetInt("MaxLevel");
        }

       Lev1.SetActive(true);

        if (n >= 1)
        {
            Lev2.SetActive(true);
            OrbLev1.SetActive(true);
        }

        if (n >= 2)
        {
            Lev3.SetActive(true);
            OrbLev2.SetActive(true);
        }

        if (n >= 3)
        { 
            Lev4.SetActive(true);
            OrbLev3.SetActive(true);
        }

        if (n >= 4)
        {
            Lev5.SetActive(true);
            OrbLev4.SetActive(true);
        }

        if (n >= 5)
        {
            Lev6.SetActive(true);
            OrbLev5.SetActive(true);
        }

        if (n >= 6)
        {
            OrbLev6.SetActive(true);
        }

    }


}
