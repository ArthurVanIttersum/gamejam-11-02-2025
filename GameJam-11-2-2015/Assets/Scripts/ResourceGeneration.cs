using UnityEngine;
using System.Collections;
using UnityFundamentals;
using System;
using UnityEngine.UI;
using TMPro;

public class ResourceGeneration : MonoBehaviour
{
    private IEnumerator coroutine;
    public IntVariable []productVariables;
    public float[] delays = {1,2,5,10};//product generation speed should be diffined here!
    private float[] PassiveIncomeUpgrades = {0,0,0,0 };
    private double exponentIncrease = 1.4;
    public double[] prices = { 1, 50, 100, 1000 };
    public IntVariable coinAmount;
    public TextMeshProUGUI[] priceTexts;
    public GameObject cow;
    public float cowRandomPositionX1;
    public float cowRandomPositionX2; 
    public float cowRandomPositionZ1;
    public float cowRandomPositionZ2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InitiatePasiveIncome(0);
    }

    // Update is called once per frame
    void Update()
    {
        //maybe update display
        for (int i = 0; i < prices.Length; i++)
        {
            priceTexts[i].text = "Price: " + prices[i];
        }
    }

    public void InitiatePasiveIncome(int productIndex)
    {
        coroutine = Spawner(productVariables[productIndex], delays[productIndex], productIndex);
        StartCoroutine(coroutine);
        print("Coroutine started");
    }

    private IEnumerator Spawner(IntVariable variable, float delay, int productIndex)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay * (float)Math.Pow(0.85f, PassiveIncomeUpgrades[productIndex]));
            variable.ChangeValueBy(1);
        }
    }

    public void UpgradePasiveIncome(int productIndex)
    {
        if (prices[productIndex] <= coinAmount.GetValue())
        {
            if (prices[productIndex] >= 1000)
            {
                exponentIncrease = 1.025f;
            }
            else if (prices[productIndex] >= 90)
            {
                exponentIncrease = 1.05f;
            }
            else if (prices[productIndex] >= 10)
            {
                exponentIncrease = 1.1f;
            }
            else
            {
                exponentIncrease = 1.4f;
            }

            PassiveIncomeUpgrades[productIndex]++;
            coinAmount.ChangeValueBy((int)-prices[productIndex]);
            if (prices[productIndex] == 1)
            {
                prices[productIndex] = 2;
            }
            else
            {
                prices[productIndex] = Math.Pow(prices[productIndex], exponentIncrease);
                prices[productIndex] = Math.Round(prices[productIndex], 0);
            }


        }
    }

    public void spawnCow()
    {
        Instantiate(cow, new Vector3(UnityEngine.Random.Range(cowRandomPositionX1,cowRandomPositionX2), -0.5f, UnityEngine.Random.Range(cowRandomPositionZ1,cowRandomPositionZ2)), cow.transform.rotation);
    }

}
