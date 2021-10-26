using UnityEngine;

public class Hit : MonoBehaviour
{
    public GameObject ExplosionParticle;
    public AudioClip AudioClip;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Laser"))
        {
            GameObject temporaryExplosion = Instantiate(ExplosionParticle, transform.position, transform.rotation);

            GameObject newParent = GameObject.FindGameObjectWithTag("MainCamera");
            temporaryExplosion.transform.parent = newParent.transform;

            GameObject scoreGO = GameObject.FindWithTag("Score");
            Score scoreComp = scoreGO.GetComponent<Score>();

            Destroy(gameObject);
            scoreComp.UpdateScore();
            SpawnEnemies.Counter--;
        }
    }
}
