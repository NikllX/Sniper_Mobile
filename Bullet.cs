using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public Vector2 direction;
    void Update()
    {
        transform.Translate(direction.normalized * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D ColAsteroid)
    {
        if (ColAsteroid.gameObject.tag == "Enemy")
        {
            Destroy(ColAsteroid.gameObject);
            Destroy(this.gameObject);
        }
        if (ColAsteroid.gameObject.tag == "Zone")
        {
            Destroy(this.gameObject);
        }
    }
}
