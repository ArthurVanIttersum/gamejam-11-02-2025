using UnityEngine;
using UnityEngine.UI;

public class priceTextScript : MonoBehaviour
{
    public Text priceText;
    public ResourceGeneration prices;
    void Update()
    {
        priceText.text = prices.prices.ToString();
    }
}
