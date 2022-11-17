using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private Camera camera;

    private void Awake()
    {
        camera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }
    // Update is called once per frame
    void Update()
    {
        //Enters whenever the mouse button is clicked 
        if (Input.GetMouseButton(0))
        {
            //cast the ray down from camera directly down from where the mouse is located
            RaycastHit2D hit = Physics2D.Raycast(camera.ScreenToWorldPoint(Input.mousePosition), -Vector2.up);
            //Will enter if ray hits something with a collider
            if(hit.collider != null)
            {
                //assigns the object hit by our ray with the x and y of the mouse
                hit.collider.gameObject.transform.position = new Vector3 (camera.ScreenToWorldPoint(Input.mousePosition).x, camera.ScreenToWorldPoint(Input.mousePosition).y, 0);
            }
        }
    }
}
