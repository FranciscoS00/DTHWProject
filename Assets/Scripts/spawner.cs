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
        if(Random.Range(0, 2) == 0) //spawn clicker
        {
            var position = new Vector2(Random.Range(-7.5f, 7.5f), Random.Range(-4.5f, 4.5f));
            Instantiate(clickPrefab, position, Quaternion.identity);
        }
        else //spawn slider
        {
            var position = new Vector2(Random.Range(-4f, 7f), Random.Range(-4.3f, 1.5f));

            Instantiate(slidePrefab, position, Quaternion.identity);
        }
    }


}
