using UnityEngine;

public class RotateAround : MonoBehaviour
{
    void Update()
    {
        gameObject.transform.RotateAround(gameObject.transform.position, gameObject.transform.up, 100 * Time.deltaTime);
    }
}
