using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mazeBall : MonoBehaviour
{
    // The plane the object is currently being dragged on
    private Plane dragPlane;
    public GameObject mainParent;
    public GameObject pauseMenu;
    public GameObject newPrefabBall;

    // The difference between where the mouse is on the drag plane and 
    // where the origin of the object is on the drag plane
    private Vector3 offset;
    private Vector3 originalPos;

    private Camera myMainCamera;

    void Start()
    {
        myMainCamera = Camera.main; // Camera.main is expensive ; cache it here
        Destroy(mainParent, globalVars.liveSpeed);
        originalPos = gameObject.transform.position;
    }

    void OnMouseDown()
    {
        if(!pauseMenu.activeSelf)
        {
            dragPlane = new Plane(myMainCamera.transform.forward, transform.position);
            Ray camRay = myMainCamera.ScreenPointToRay(Input.mousePosition);

            float planeDist;
            dragPlane.Raycast(camRay, out planeDist);
            offset = transform.position - camRay.GetPoint(planeDist);
        }
    }

    void OnMouseDrag()
    {
        if(!pauseMenu.activeSelf)
        {
            Ray camRay = myMainCamera.ScreenPointToRay(Input.mousePosition);

            float planeDist;
            dragPlane.Raycast(camRay, out planeDist);
            transform.position = camRay.GetPoint(planeDist) + offset;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Barrier") //MazePath need to have the "Barrier" tag
        {
            //here you can add what it should do when it hits the wall
            globalVars.tries++;
            GameObject newPrefab = Instantiate(gameObject, originalPos, Quaternion.identity);
            if(gameObject.transform.localScale.x > 0.06)
            {
                newPrefab.transform.localScale = gameObject.transform.localScale - new Vector3(0.01f,0.01f,0);
            }
            Destroy(gameObject);
        }else if(collision.gameObject.tag == "Win") //MazeHoop needs to have the "Win" tag
        {
            //add whatever you want to happen when you touch the hoop (final)
            //Debug.Log("ganhei");
            SceneManager.LoadScene("ResultsMenu", LoadSceneMode.Single);
        }
    }
}
