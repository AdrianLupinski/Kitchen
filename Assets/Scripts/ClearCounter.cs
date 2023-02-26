using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter
{

    public override void Interact(Player player)
    {
        if (player.HasKitchenObject() && !HasKitchenObject())
        {
            player.GetKitchenObject().SetKichenObjectParent(this);
        }
        else if (player.HasKitchenObject() == false && HasKitchenObject())
        {
            GetKitchenObject().SetKichenObjectParent(player);
        }
    }

}
