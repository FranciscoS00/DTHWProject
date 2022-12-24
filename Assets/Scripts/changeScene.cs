using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    [SerializeField]
    string goToScene;

    void Start()
    {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(ModifyScene);
    }

    public void ModifyScene()
    {
        if(goToScene == null || goToScene == "")
        {
            goToScene = "Intro";
        }
        SceneManager.LoadScene(goToScene, LoadSceneMode.Single);
    }
}
