using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SideWall : MonoBehaviour
{
    [SerializeField] private UnityEvent ScoreTrigger;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Balls"))
        {
            print("p1 hits balls");
        }
    }
}
