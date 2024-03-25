using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class MoneyGenerator : MonoBehaviour
{
    [SerializeField] private Image moneyDarkImage;
    private RectTransform rt;
    private int moneyOnLevel=0;
    [SerializeField] private int deltaMoneyChange = 8;
    [SerializeField] private TextMeshProUGUI moneyText;

    private void Awake()
    {
        rt = moneyDarkImage.GetComponent<RectTransform>();
    }


    public void StartMoneyGenerator()
    {
        MoneyOnStartLevel();
    }



    public void MoneyOnStartLevel()
    {
        moneyOnLevel = 0;
        moneyText.text = moneyOnLevel + "$";
        rt.sizeDelta = new Vector2(rt.sizeDelta.x, 0);
        StartCoroutine(MoneyGenerate());   
    }

    IEnumerator MoneyGenerate()
    {
        while (rt.sizeDelta.y <= 150)
        {
            rt.sizeDelta = new Vector2(rt.sizeDelta.x, rt.sizeDelta.y + 1.5f);
            yield return new WaitForSecondsRealtime(0.02f);
        }
        moneyOnLevel += deltaMoneyChange;
        moneyText.text = moneyOnLevel + "$";
        rt.sizeDelta = new Vector2(rt.sizeDelta.x, 0);
        StartCoroutine(MoneyGenerate());
    }

    public void SetDeltaMoneyChange(int newDeltaMoney)
    {
        deltaMoneyChange = newDeltaMoney;
    }

    public int GetDeltaMoneyChange()
    {
        return deltaMoneyChange;
    }

}
