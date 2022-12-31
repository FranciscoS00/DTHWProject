using UnityEngine;
using TMPro;

public class changeText : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI m_Object;

    void Start()
    {
        m_Object.text = "Nível " + globalVars.level.ToString();
    }
    private void Update()
    {
        m_Object.text = "Nível " + globalVars.level.ToString();
    }
}
