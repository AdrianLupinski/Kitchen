using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedCounter : MonoBehaviour
{
    [SerializeField]
    private BaseCounter baseCounter;
    [SerializeField]
    private GameObject[] selectedVisualArray;

    void Start()
    {
        Player.Instance.OnSelectedCounterChanged += Instance_OnSelectedCounterChanged;
    }

    private void Instance_OnSelectedCounterChanged(object sender, Player.OnSelectedCounterChangedEventArgs e)
    {
        if (e.selectedCounter == baseCounter)
        {
            Show();
        }
        else if (e.selectedCounter != baseCounter)
        {
            Hide();
        }

    }

    private void Hide()
    {
        foreach (GameObject gameObject in selectedVisualArray)
        {
            gameObject.SetActive(false);
        }
    }

    private void Show()
    {
        foreach (GameObject gameObject in selectedVisualArray)
        {
            gameObject.SetActive(true);
        }
    }

}
