using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fix : MonoBehaviour
{

    
    public bool checkpointReached;
    public float FixDelay = 1f;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Hummer")
        {
            gameObject.GetComponent<Animator>().SetBool("fix", true);

            other.gameObject.GetComponent<Animator>().enabled = true;
            other.gameObject.GetComponent<Animator>().SetBool("Rotate",true);
            ///StartCoroutine(Fxx5(other.gameObject));
            checkpointReached = true;
        }

    }



    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Hummer")
        {
            //checkpointSpriteRenderer.sprite = greenFlag;
            other.gameObject.GetComponent<Animator>().SetBool("Rotate",false);
            other.gameObject.GetComponent<Animator>().enabled = false;
        }
    }

    public IEnumerator Fxx5( GameObject obj)
    {
           yield return new WaitForSeconds(FixDelay);

        obj.GetComponent<Animator>().SetBool("Rotate", false);

    }

}
