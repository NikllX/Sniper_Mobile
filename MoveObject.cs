using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public GameObject Player;
    public float moveSpeed = 3;
    public Vector2 direction;
    void Start()
    {
        Vector3 targ = Player.transform.position;
        targ.z = 0f;

        Vector3 objectPos = transform.position;
        targ.x = targ.x - objectPos.x;
        targ.y = targ.y - objectPos.y;

        float angle = Mathf.Atan2(targ.y, targ.x) * Mathf.Rad2Deg;

        float Rx = Player.gameObject.transform.position.x;
        float Ry = Player.gameObject.transform.position.y;
        float Rz = Player.gameObject.transform.position.z;

        Vector3 relativePoint = transform.InverseTransformPoint(Rx, Ry, Rz); 
        direction = new Vector2(relativePoint.x, relativePoint.y);
    }

    void Update()
    {
        transform.Translate(direction.normalized * Time.deltaTime * moveSpeed);
    }
}
