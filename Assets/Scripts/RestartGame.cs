using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class RestartGame : MonoBehaviour
{
    void Start()
    {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(Restart);
    }

    void Restart()
    {
        globalVars.spawnSpeed = 1.0f;
        globalVars.liveSpeed = 2.0f;
        globalVars.level = 1;
        globalVars.last10 = 0;
        globalVars.last10Score = 0;
        globalVars.tries = 1;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
