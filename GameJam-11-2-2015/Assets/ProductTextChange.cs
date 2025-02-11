using TMPro;
using UnityEngine;
using UnityFundamentals;

public class ProductTextChange : MonoBehaviour
{
    public IntVariable product;
    public TextMeshProUGUI productText;
    public void Update()
    {
        productText.text = "Coins: " + product.GetValue();
    }
}
