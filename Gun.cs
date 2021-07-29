using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    public float offset;
    public GameObject bullet;
    public Transform shotPoint;
    public Joystick joystick;
    private float timeBtwShots;
    public float startTimeBtwShots;
    private float rotationZ;
    private Vector3 difference;
    public Button RestartLevel;
    public int Live = 3;
    public GameObject PlayerBase;

    void Update()
    {
        rotationZ = Mathf.Atan2(joystick.Vertical, joystick.Horizontal) * Mathf.Rad2Deg;

        if (joystick.Horizontal != 0 || joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, rotationZ + offset);
        }
        

        if (timeBtwShots <= 0)
        {
            if (joystick.Horizontal != 0 || joystick.Vertical != 0)
            {
                Shoot();
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }

        if (Live == 0)
        {
            RestartLevel.gameObject.SetActive(true);
            Destroy(PlayerBase.gameObject);
        }
    }

    public void Shoot()
    {
        GameObject newBullet = Instantiate(bullet, shotPoint.position, Quaternion.Euler(0.0f, 0.0f, rotationZ - 90 ));
        timeBtwShots = startTimeBtwShots;
        Destroy(newBullet, 5);
    }

    private void OnCollisionEnter2D(Collision2D ColAsteroid)
    {
        if (ColAsteroid.gameObject.tag == "Enemy")
        {
            Destroy(ColAsteroid.gameObject);
            Live -= 1;

        }
    }
    private void OnTriggerEnter2D(Collider2D ColAsteroid)
    {
        if (ColAsteroid.gameObject.tag == "Enemy")
        {
            Destroy(ColAsteroid.gameObject);
            Live -= 1;

        }
    }
}
