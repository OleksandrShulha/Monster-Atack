using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundPanelImage : MonoBehaviour
{
    [SerializeField] Sprite[] backgroundImage;
    private int maxActiveChild = 8;
    
    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SetActivePanelSize();
    }


    //Розмір панелі підложки для вибору бійців на рівні в залежності від кількості активованих
    public void SetActivePanelSize()
    {
        int activeChild = 0;

        foreach (Transform child in gameObject.transform)
        {
            if (child.gameObject.activeInHierarchy == true)
            {
                activeChild++;
            }
        }
        //Debug.Log(activeChild);
        if (activeChild == 0)
        {
            Debug.Log("ноль активных героев");
        }
        else if (activeChild <= maxActiveChild)
        {
            transform.GetComponent<Image>().sprite = backgroundImage[activeChild - 1];
        }
        else
        {
            transform.GetComponent<Image>().sprite = backgroundImage[maxActiveChild-1];
        }
        transform.GetComponent<Image>().SetNativeSize();

    }
}
