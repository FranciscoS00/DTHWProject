using UnityEngine;
using UnityEngine.UI;

public class starSystem : MonoBehaviour
{

    public GameObject starImage1, starImage2, starImage3;
    void Start()
    {
        if(globalVars.tries > 2)
        {
            starImage3.SetActive(false);
        }
        if(globalVars.tries > 5)
        {
            starImage2.SetActive(false);
        }
    }
}