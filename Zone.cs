using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Zone : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D ColAsteroid)
    {

        if (ColAsteroid.gameObject.tag == "Bullet")
        {
            Destroy(ColAsteroid.gameObject);
        }

        if (ColAsteroid.gameObject.tag == "Enemy")
        {
            Destroy(ColAsteroid.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D ColAsteroid)
    {
        if (ColAsteroid.gameObject.tag == "Bullet")
        {
            Destroy(ColAsteroid.gameObject);
        }

        if (ColAsteroid.gameObject.tag == "Enemy")
        {
            Destroy(ColAsteroid.gameObject);
        }
    }

}
