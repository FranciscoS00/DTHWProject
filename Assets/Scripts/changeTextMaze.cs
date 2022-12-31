using UnityEngine;
using TMPro;

public class changeTextMaze : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI m_Object;

    void Start()
    {
        m_Object.text = "Tentativa #" + globalVars.tries.ToString();
    }
    private void Update()
    {
        m_Object.text = "Tentativa #" + globalVars.tries.ToString();
    }
}
