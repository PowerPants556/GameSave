using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodConn : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Tail")
        {
            Destroy(gameObject);
        }
    }
}
