using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starChecker : MonoBehaviour
{
    [SerializeField]
    int level;
    [SerializeField]
    GameObject star1, star2, star3;
    void Start()
    {
        int numberOfStars = globalVars.levelStars[level - 1];
        switch (numberOfStars)
        {
            case 1:
                star1.SetActive(true);
                break;
            case 2:
                star1.SetActive(true);
                star2.SetActive(true);
                break;
            case 3:
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
                break;
            default:
                break;
        }
    }
}
