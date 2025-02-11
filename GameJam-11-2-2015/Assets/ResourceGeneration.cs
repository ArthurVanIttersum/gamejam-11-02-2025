using UnityEngine;
using System.Collections;
using UnityFundamentals;

public class ResourceGeneration : MonoBehaviour
{
    private IEnumerator coroutine;
    public IntVariable []productVariables;
    public float[] delays = {10,5,2,1};//product generation speed should be diffined here!

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

    public void InitiatePasiveIncome(int ProductIndex)
    {
        coroutine = Spawner(productVariables[ProductIndex], delays[ProductIndex]);
        StartCoroutine(coroutine);
        print("Coroutine started");
    }

    private IEnumerator Spawner(IntVariable variable, float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            variable.ChangeValueBy(1);
        }
    }

}
