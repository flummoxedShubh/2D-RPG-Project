using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : Character
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Consumable consumableObject = collision.gameObject.GetComponent<Consumable>();

        if(consumableObject != null)
        {
            Item hitObject = consumableObject.item;

            if (hitObject != null)
            {
                print("Hit: " + hitObject.objectName);

                switch (hitObject.itemType)
                {
                    case Item.ItemType.COIN:
                        break;

                    case Item.ItemType.HEALTH:
                        AdjustHitPoints(hitObject.quantity);
                        break;

                    default:
                        break;
                }

                collision.gameObject.SetActive(false);
            }

        }

    }
    public void AdjustHitPoints(int amount)
    {
        hitPoints += amount;
        print("Adjusted HitPoints by: " + amount + ". New value: " + hitPoints);
    }
}

