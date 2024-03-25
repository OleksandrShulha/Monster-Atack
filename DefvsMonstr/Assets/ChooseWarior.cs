using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseWarior : MonoBehaviour
{
    [SerializeField] private bool isActive = false;
    [SerializeField] Button btn;

    public void ClickBtn()
    {
        isActive = !isActive;
        Image img = btn.GetComponent<Image>();
        if(isActive)
            img.color = Color.blue;
        else
            img.color = Color.white;
    }


    public bool isActives()
    {
        return isActive;
    }

}
