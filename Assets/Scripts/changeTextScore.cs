using UnityEngine;
using TMPro;

public class changeTextScore : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI m_Object;
    private int tempStarNumber = 0;

    void Start()
    {

        switch (globalVars.tries)
        {
            case 1:
            case 2:
            case 3:
                tempStarNumber = 3;
                break;
            case 4:
            case 5:
            case 6:
                tempStarNumber = 2;
                break;
            case 7:
            case 8:
            case 9:
                tempStarNumber = 1;
                break;
            default:
                tempStarNumber = 0;
                break;
        }
        m_Object.text = tempStarNumber.ToString() + " estrela(s)!";
    }
    private void Update()
    {
        m_Object.text = tempStarNumber.ToString() + " estrela(s)!";
    }
}
