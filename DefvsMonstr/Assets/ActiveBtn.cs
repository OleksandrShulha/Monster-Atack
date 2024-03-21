using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveBtn : MonoBehaviour
{
    [SerializeField] Button[] bts;
    [SerializeField] GameObject[] panel;
    int countActiveBtn;
    BackgroundPanelImage bgimg;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CountActiveBtn()
    {

        countActiveBtn = 0;
        for (int i = 0; i < bts.Length; i++)
        {
            if (bts[i].GetComponent<ChooseWarior>().isActives() == true)
            {
                countActiveBtn++;
            }
        }
        Debug.Log("Активных кнопок: " + countActiveBtn);

        if(countActiveBtn >= 8)
        {
            for (int i = 0; i < bts.Length; i++)
            {
                if (bts[i].GetComponent<ChooseWarior>().isActives() == false)
                {
                    bts[i].interactable = false;
                    bts[i].GetComponent<Image>().color = Color.red;

                }
            }
        } else 
        {
            for (int i = 0; i < bts.Length; i++)
            {
                if (bts[i].GetComponent<ChooseWarior>().isActives() == false)
                {
                    bts[i].interactable = true;
                    bts[i].GetComponent<Image>().color = Color.white;

                }
            }
        }
    }

    public void ActivePanel()
    {
        for (int i = 0; i < bts.Length; i++)
        {
            if (bts[i].GetComponent<ChooseWarior>().isActives() == false)
            {
                panel[i].gameObject.SetActive(false);
            }
            else
            {
                panel[i].gameObject.SetActive(true);
            }
        }

       
    }




}
