using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyPlaces : MonoBehaviour
{
    public GameObject ObjectSpawn;
    public GameObject[] Place;
    public float TimeSpawn = 5f;
    public float TimeDelete= 7f;
    public GameObject Player;
    public GameObject SpawnEB;
    void Start()
    {
        StartCoroutine(Spawner());
    }
    IEnumerator Spawner()
    {
        while (true)
        {

            yield return new WaitForSeconds(TimeSpawn);
            int randId = Random.Range(0, Place.Length);
            if (GameObject.Find("Player") != null)
            {
                GameObject newObjectSpawn = Instantiate(ObjectSpawn, new Vector3(Place[randId].transform.position.x, Place[randId].transform.position.y, 0), Quaternion.identity);
                newObjectSpawn.GetComponent<Enemy>().Player = Player;
                newObjectSpawn.GetComponent<Enemy>().ObjectSpawn = SpawnEB;
                Destroy(newObjectSpawn, TimeDelete);
            }
        }
    }
}
