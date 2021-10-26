using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject Laser;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GameObject temporaryLaser = Instantiate(Laser, gameObject.transform.position, gameObject.transform.rotation);

            GameObject newParent = GameObject.FindGameObjectWithTag("MainCamera");
            temporaryLaser.transform.parent = newParent.transform;

            Rigidbody laserRigidbody = temporaryLaser.GetComponent<Rigidbody>();
            // Forward
            laserRigidbody.AddForce(transform.up * -1000);

            Destroy(temporaryLaser, 3f);
        }
    }
}
