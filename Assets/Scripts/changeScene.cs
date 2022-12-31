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

    void Start()
    {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(ModifyScene);
    }

    public void ModifyScene()
    {
        if (isExit)
        {
            Application.Quit();
        }
        if (goToScene != null && goToScene != "")
        {
            SceneManager.LoadScene(goToScene, LoadSceneMode.Single);
        }
    }
}
