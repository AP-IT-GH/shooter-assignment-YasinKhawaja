using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject Enemy;
    public static int Counter = 0;

    GameObject _camera;
    void Start()
    {
        _camera = GameObject.FindWithTag("MainCamera");
    }

    void Update()
    {
        if (Counter < 5)
        {
            Vector3 spawnPosition = _camera.transform.forward * 30 + _camera.transform.position;
            GameObject enemy = Instantiate(Enemy, spawnPosition, Quaternion.identity);
            enemy.transform.parent = _camera.transform;
            enemy.transform.localPosition = new Vector3(Random.Range(-6.5f, 6.5f), Random.Range(-4f, 4f), Random.Range(15f, 40f));
            Counter++;
        }
    }
}
