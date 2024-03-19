using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundPanelImage : MonoBehaviour
{
    [SerializeField] Sprite[] backgroundImage;
    
    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SetActivePanelSize();
    }

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
        transform.GetComponent<Image>().sprite = backgroundImage[activeChild - 1];
        transform.GetComponent<Image>().SetNativeSize();
    }
}
