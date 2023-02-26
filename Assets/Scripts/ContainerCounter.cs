using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ContainerCounter : BaseCounter
{
    public event EventHandler OnPlayerGrabObject;

    [SerializeField] 
    private KitchenObjectSO kitchenObjectSO;

    public override void Interact(Player player)
    {
        if (player.HasKitchenObject() == false)
        {
            OnPlayerGrabObject?.Invoke(this, EventArgs.Empty);

            KitchenObject.SpawnKitchenObject(kitchenObjectSO, player);

        }
    }
}
