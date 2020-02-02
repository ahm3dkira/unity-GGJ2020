using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//SampleScene

public class seen : MonoBehaviour
{
    [SerializeField] private string newlevel;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {
            SceneManager.LoadScene(newlevel);
        }
    }



    void Start() { }


    void Update() { }
}
