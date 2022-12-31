using UnityEngine;
using TMPro;

public class changeTextResults : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI m_Object;

    void Start()
    {
        m_Object.text = "Nível " + globalVars.level.ToString() + " concluído!";
    }
    private void Update()
    {
        m_Object.text = "Nível " + globalVars.level.ToString() + " concluído!";
    }
}
