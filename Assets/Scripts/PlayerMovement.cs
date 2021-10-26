using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
    public float Xspeed = 10f;
    public float Yspeed = 10f;

    void Update()
    {
        float horizontal = CrossPlatformInputManager.GetAxis("Horizontal");
        float xOffset = horizontal * Time.deltaTime * Xspeed;
        float xNewPosition = xOffset + transform.localPosition.x;

        float vertical = CrossPlatformInputManager.GetAxis("Vertical");
        float yOffset = vertical * Time.deltaTime * Yspeed;
        float yNewPosition = yOffset + transform.localPosition.y;

        Vector3 newPositions = new Vector3(
            Mathf.Clamp(xNewPosition, -7.5f, 7.5f),
            Mathf.Clamp(yNewPosition, -4f, 4f),
            transform.localPosition.z);

        transform.localPosition = newPositions;
    }
}
