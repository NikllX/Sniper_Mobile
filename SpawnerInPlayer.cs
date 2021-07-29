using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnerInPlayer : MonoBehaviour
{
    public GameObject ObjectSpawn;
    public GameObject Player;
    public float TimeSpawn = 5f;

    void Start()
    {
        StartCoroutine(Spawner());
    }
    IEnumerator Spawner()
    {
        while (true)
        {

            yield return new WaitForSeconds(TimeSpawn);       
            if (GameObject.Find("Player") != null)
            {
                GameObject newObjectSpawn = Instantiate(ObjectSpawn, new Vector3(this.transform.position.x, this.transform.position.y, 0), Quaternion.identity);
                newObjectSpawn.GetComponent<MoveObject>().Player = Player;
                Destroy(newObjectSpawn, 10);
            }
        }
    }
}
