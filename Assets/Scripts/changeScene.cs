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
        if(isExit)
        {
            Application.Quit();
        }
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(ModifyScene);
    }

    public void ModifyScene()
    {
        if(goToScene != null && goToScene != "")
        {
            SceneManager.LoadScene(goToScene, LoadSceneMode.Single);
        }
    }
}
