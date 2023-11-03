using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooting : MonoBehaviour
{
    public Transform targetPos;
    private Vector3 dir;
    internal float speed, damage;

    public void Start()
    {
        dir = targetPos.position - transform.position;
        dir.Normalize();
        
    }
    public void Update()
    {
        if (targetPos == null)
        {
            return;
        }

        transform.position += dir * Time.deltaTime * speed;
    }
}
