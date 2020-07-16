using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : Controller
{
    protected override void Update()
    {

        base.Update();
    }

    protected void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Waypoint"))
        {
            direction *= -1;
        }
    }
}
