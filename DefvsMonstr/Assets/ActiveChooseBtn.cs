using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveChooseBtn : MonoBehaviour
{
    ActiveBtn activeBtn;

    void Start()
    {
        activeBtn = FindAnyObjectByType<ActiveBtn>();
    }

    void Update()
    {
        if (activeBtn.GetCountActiveBtn() > 0)
        {
            transform.GetComponent<Image>().color = Color.white;
            transform.GetComponent<Button>().interactable = true;
        }
        else
        {
            transform.GetComponent<Button>().interactable = false;
            transform.GetComponent<Image>().color = Color.red;
        }

    }
}
