using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IKichenObjectParent
{
    public KitchenObject GetKitchenObject();

    public void SetKitchenObject(KitchenObject kitchenObject);

    public Transform GetKitchenObjectFollowTranform();

    public void ClearKitchenObject();

    public bool HasKitchenObject();
}
