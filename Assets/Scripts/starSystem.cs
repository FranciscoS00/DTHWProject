using UnityEngine;
using UnityEngine.UI;

public class starSystem : MonoBehaviour
{

    public GameObject starImage1, starImage2, starImage3;
    void Start()
    {
        if(globalVars.tries >= 3)
        {
            starImage3.SetActive(false);
        }
        if(globalVars.tries >= 6)
        {
            starImage2.SetActive(false);
        }
        if(globalVars.tries >= 9)
        {
            starImage1.SetActive(false);
        }

        if (globalVars.tries <= 3 && globalVars.tries >= 1)
        {
            globalVars.levelStars[globalVars.level - 1] = Mathf.Max(globalVars.levelStars[globalVars.level - 1], 3);
        }
        else if (globalVars.tries <= 6 && globalVars.tries >= 4)
        {
            globalVars.levelStars[globalVars.level - 1] = Mathf.Max(globalVars.levelStars[globalVars.level - 1], 2);
        }
        else if (globalVars.tries <= 9 && globalVars.tries >= 7)
        {
            globalVars.levelStars[globalVars.level - 1] = Mathf.Max(globalVars.levelStars[globalVars.level - 1], 1);
        }
        else
        {
            globalVars.levelStars[globalVars.level - 1] = Mathf.Max(globalVars.levelStars[globalVars.level - 1], 0);
        }
    }
}
