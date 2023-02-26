using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingCounter : BaseCounter
{
    [SerializeField]
    private KitchenObjectSO kitchenObjectSO;

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

    public override void InteractAlternate(Player player)
    {
        if (HasKitchenObject()) 
        {
            GetKitchenObject().DestroySelf();

            KitchenObject.SpawnKitchenObject(kitchenObjectSO, this);
        }
    }
}
