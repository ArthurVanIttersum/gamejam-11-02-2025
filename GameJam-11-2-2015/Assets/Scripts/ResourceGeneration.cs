using UnityEngine;
using System.Collections;
using UnityFundamentals;
using System;

public class ResourceGeneration : MonoBehaviour
{
    private IEnumerator coroutine;
    public IntVariable []productVariables;
    public float[] delays = {1,2,5,10};//product generation speed should be diffined here!
    public float[] PassiveIncomeUpgrades = {0,0,0,0 };
    private double exponentIncrease = 1.4;
    public double[] prices = { 1, 50, 100, 1000 };
    public IntVariable coinAmount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InitiatePasiveIncome(0);
    }

    // Update is called once per frame
    void Update()
    {
        //maybe update display
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
            yield return new WaitForSeconds(delay * (float)Math.Pow(0.9f, PassiveIncomeUpgrades[productIndex]));
            variable.ChangeValueBy(1);
        }
    }

    public void UpgradePasiveIncome(int productIndex)
    {
        if (prices[productIndex] <= coinAmount.GetValue())
        {
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

        }
    }

}
