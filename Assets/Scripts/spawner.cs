using UnityEngine;

public class spawner : MonoBehaviour
{

    public GameObject clickPrefab, slidePrefab;

    void Start()
    {
        var position = new Vector2(Random.Range(-7.5f, 7.5f), Random.Range(-4.5f, 4.5f));
        Instantiate(clickPrefab, position, Quaternion.identity);
        InvokeRepeating("spawn", 1f, globalVars.spawnSpeed);
    }

    void spawn()
    {
        var position = new Vector2(Random.Range(-7.5f, 7.5f), Random.Range(-4.5f, 4.5f));
        Instantiate(clickPrefab, position, Quaternion.identity);
    }


}
