using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCounter : MonoBehaviour, IKichenObjectParent
{
    [SerializeField]
    private Transform instantiatePlace;


    private KitchenObject kitchenObject;

    public virtual void InteractAlternate(Player player)
    {

    }

    public virtual void Interact(Player player)
    {

    }

    public KitchenObject GetKitchenObject()
    {
        return kitchenObject;
    }

    public void SetKitchenObject(KitchenObject kitchenObject)
    {
        this.kitchenObject = kitchenObject;
    }

    public Transform GetKitchenObjectFollowTranform()
    {
        return instantiatePlace;
    }

    public void ClearKitchenObject()
    {
        kitchenObject = null;
    }

    public bool HasKitchenObject()
    {
        return kitchenObject != null;
    }
}
