using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class CuttingRecipeSO : ScriptableObject
{

    [SerializeField]
    private KitchenObjectSO input;
    [SerializeField]
    private KitchenObjectSO output;

}
