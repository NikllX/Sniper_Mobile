using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject ObjectSpawn;
    public GameObject Player;
    private GameObject newObjectSpawn;
    void Start()
    {
        newObjectSpawn = Instantiate(ObjectSpawn, new Vector3(this.transform.position.x,this.transform.position.y, 0), Quaternion.identity);
        newObjectSpawn.GetComponent<SpawnerInPlayer>().Player = Player;
    }

    private void OnCollisionEnter2D(Collision2D ColAsteroid)
    {
        if (ColAsteroid.gameObject.tag == "Bullet")
        {
            Destroy(ColAsteroid.gameObject);
            Destroy(newObjectSpawn.gameObject);

        }
    }
    private void OnTriggerEnter2D(Collider2D ColAsteroid)
    {
        if (ColAsteroid.gameObject.tag == "Bullet")
        {
            Destroy(newObjectSpawn.gameObject);
            Destroy(ColAsteroid.gameObject);

        }
    }
}
