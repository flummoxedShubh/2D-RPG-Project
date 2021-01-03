using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : Character
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Item hitObject = collision.gameObject.GetComponent<Consumable>().item;

        if(hitObject != null)
        {
            print("Hit: " + hitObject.objectName);
            collision.gameObject.SetActive(false);
        }
    }
}
