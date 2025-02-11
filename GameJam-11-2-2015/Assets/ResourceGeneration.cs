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
        PassiveIncomeUpgrades[productIndex]++;
    }

}
