using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballDrag : MonoBehaviour
{
    // The plane the object is currently being dragged on
    private Plane dragPlane;
    public Collider2D square, hoop;
    public GameObject mainParent;

    // The difference between where the mouse is on the drag plane and 
    // where the origin of the object is on the drag plane
    private Vector3 offset;

    private Camera myMainCamera;

    void Start()
    {
        myMainCamera = Camera.main; // Camera.main is expensive ; cache it here
        Destroy(mainParent, globalVars.liveSpeed);
    }

    void OnMouseDown()
    {
        dragPlane = new Plane(myMainCamera.transform.forward, transform.position);
        Ray camRay = myMainCamera.ScreenPointToRay(Input.mousePosition);

        float planeDist;
        dragPlane.Raycast(camRay, out planeDist);
        offset = transform.position - camRay.GetPoint(planeDist);
    }

    void OnMouseDrag()
    {
        Ray camRay = myMainCamera.ScreenPointToRay(Input.mousePosition);

        float planeDist;
        dragPlane.Raycast(camRay, out planeDist);
        transform.position = camRay.GetPoint(planeDist) + offset;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision == hoop)
        {
            globalVars.last10Score = globalVars.last10Score + 1;
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision == square)
        {
            Destroy(mainParent);
        }
    }

    private void OnDestroy()
    {
        globalVars.last10 = globalVars.last10 + 1;
    }
}
