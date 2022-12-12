using UnityEngine;
using UnityEngine.UI;

public class ResumeGame : MonoBehaviour
{
    void Start()
    {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(Resume);
    }

    void Resume()
    {
        Time.timeScale = 1;
    }
}
