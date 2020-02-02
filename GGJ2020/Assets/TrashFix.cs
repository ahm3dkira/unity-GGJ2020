using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashFix : MonoBehaviour
{

    private bool ishold = false;


    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        if ((ishold == true))
        {
            if (Input.mousePosition.x > 10 && Input.mousePosition.x < Screen.width - 10)
            {
                if (Input.mousePosition.y > 10 && Input.mousePosition.y < Screen.height - 10)
                {

                    Vector3 mousepos;
                    mousepos = Input.mousePosition;
                    mousepos = Camera.main.ScreenToWorldPoint(mousepos);

                    this.gameObject.transform.localPosition = new Vector3(mousepos.x, mousepos.y, 0);

                }
            }

        }

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Trash")
        {
            StartCoroutine(Fxx5(other.gameObject));
        }
    }
    /*
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Trash")
        {
            StartCoroutine(Fxx5(other.gameObject));
        }
        */

    public IEnumerator Fxx5(GameObject obj)
    {

        //obj.GetComponent<Animator>().SetBool("Rotate", false);
        yield return new WaitForSeconds(0.5f);
        Destroy(obj);
        //    checkpointSpriteRenderer.sprite = greenFlag;

        //    yield return new WaitForSeconds(FixDelay);

        //  checkpointSpriteRenderer.sprite = greenFlag2;

        

    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Vector3 mousepos;
            //mousepos = Input.mousePosition;
            //mousepos = Camera.main.ScreenToWorldPoint(mousepos);

            ishold = true;
        }

    }
    private void OnMouseUp()
    {
        ishold = false;
    }
}
