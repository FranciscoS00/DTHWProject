using UnityEngine;
using UnityEngine.UI;

public class ResumeGame : MonoBehaviour
{
    public GameObject pauseMenu;
    void Start()
    {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(Resume);
    }

    void Resume()
    {
        Time.timeScale = 1;
        globalVars.pauseMenuActive = false;
        pauseMenu.SetActive(false);
    }
}
