using UnityEngine;
using TMPro;

public class changeText : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI m_Object;

    void Start()
    {
        m_Object.text = "Nivel " + globalVars.level.ToString() + ", last10: " + globalVars.last10.ToString() + ", last10Score: " + globalVars.last10Score.ToString();
    }
    private void Update()
    {
        m_Object.text = "Nivel " + globalVars.level.ToString() + ", last10: " + globalVars.last10.ToString() + ", last10Score: " + globalVars.last10Score.ToString();
    }
}
