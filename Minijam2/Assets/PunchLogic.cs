using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class PunchLogic : MonoBehaviour
{
    //public float radius = 1f;
    public ContactFilter2D cf2d;
    void Punch(Vector2 point, float radius, int damage, Vector2 force)
    {
        CircleCollider2D[] hits = new CircleCollider2D[0];
        Physics2D.OverlapCircle(point, radius,cf2d, hits);
        foreach(CircleCollider2D hit in hits)
        {
            if (hit.gameObject.tag == "ENEMY")
            {
                hit.gameObject.GetComponent<EnemyLogic>().takeDamage(damage, force);
            }
        }
    }

}
