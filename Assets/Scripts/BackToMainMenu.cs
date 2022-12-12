using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    void Start()
    {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(MainMenu);
    }

    void MainMenu()
    {
        SceneManager.LoadScene("Intro", LoadSceneMode.Single);
    }
}
