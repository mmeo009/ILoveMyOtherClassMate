using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turn : MonoBehaviour
{
    public bool isTurn = false;
    public GameObject uiButton;
    public void UiActive()
    {
        uiButton.GetComponent<Image>().raycastTarget = !isTurn;
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            isTurn = !isTurn;
            UiActive();
        }
    }
}
