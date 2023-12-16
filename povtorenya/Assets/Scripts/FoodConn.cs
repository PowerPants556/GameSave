using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodConn : MonoBehaviour
{
    public int size = 0;
 //   private static int size = 0;
    private void Start()
    {
 //       sizeof = Random.Range(0, 100);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Tail")
        {
            Destroy(gameObject);
        }
    }
}
