using UnityEngine;
using UnityEngine.UI;

public class pauseGame : MonoBehaviour
{

    public GameObject pauseMenu;
    void Start()
    {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(Pause);
    }

    void Pause()
    {
        Time.timeScale = 0;
        globalVars.pauseMenuActive = true;
        pauseMenu.SetActive(true);
    }
}
