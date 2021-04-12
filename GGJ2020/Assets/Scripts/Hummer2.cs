using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hummer2 : MonoBehaviour
{
    
    private bool ishold = false;
    
    void Update()
    {
        if((ishold == true))
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

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ishold = true;
        }
    
    }
    private void OnMouseUp()
    {
        ishold = false;
    }
    

}
