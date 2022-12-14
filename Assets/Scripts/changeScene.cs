using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class changeScene : MonoBehaviour
{
    [SerializeField]
    string goToScene;
    [SerializeField]
    bool isExit = false;
    public int chosenLevel = -1;
    public int isDynamicLevel = 0;

    void Start()
    {
        if(isDynamicLevel == 2 && globalVars.level >= 10)
        {
            gameObject.SetActive(false);
        }
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(RestartData);
        btn.onClick.AddListener(ModifyScene);
    }

    void RestartData()
    {
        if(isDynamicLevel == 2)
        {
            globalVars.level = globalVars.level + 1;
        }
        else if(chosenLevel != -1)
        {
            globalVars.level = chosenLevel;
        }
        globalVars.tries = 1;
        Time.timeScale = 1;
    }

    public void ModifyScene()
    {
        globalVars.pauseMenuActive = false;
        if (isExit)
        {
            Application.Quit();
        }
        if (goToScene != null && goToScene != "")
        {
            if(isDynamicLevel != 0)
            {
                SceneManager.LoadScene(goToScene+globalVars.level, LoadSceneMode.Single);
            }
            else if(chosenLevel != -1 && goToScene == "Maze")
            {
                SceneManager.LoadScene(goToScene+chosenLevel, LoadSceneMode.Single);
            }
            else
            {
                SceneManager.LoadScene(goToScene, LoadSceneMode.Single);
            }
        }
    }
}
