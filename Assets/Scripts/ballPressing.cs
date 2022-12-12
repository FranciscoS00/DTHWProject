using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;


public class ballPressing : MonoBehaviour
{
    private void OnMouseDown()
    {
        globalVars.last10Score = globalVars.last10Score + 1;
        Destroy(gameObject);
    }

    void Start()
    {
        Destroy(gameObject, 2.0f);
    }

    private void OnDestroy()
    {
        globalVars.last10 = globalVars.last10 +1;
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(globalVars.liveSpeed);
        Destroy(gameObject);
    }
}
