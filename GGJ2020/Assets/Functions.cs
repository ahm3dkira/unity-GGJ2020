using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Functions : MonoBehaviour
{
    public static bool isPause = false;
    public GameObject PauseMeunUI;
    [SerializeField] private string newlevel;

    // Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}

    public void GResume()
    {
        PauseMeunUI.SetActive(false);
        Time.timeScale = 1f;
        isPause = false;
    }

    public void Grestart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Gstart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(newlevel);
    }

    public void GPause()
    {
        PauseMeunUI.SetActive(true);
        Time.timeScale = 0f;
        isPause = true;
    }
    public void GQuit()
    {
        Application.Quit();
    }


}
