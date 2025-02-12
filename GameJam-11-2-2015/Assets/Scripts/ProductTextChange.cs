using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityFundamentals;

public class ProductTextChange : MonoBehaviour
{
    public IntVariable product;
    public TextMeshProUGUI productText;
    public UnityEvent unityEvent;
    public void Update()
    {
        productText.text = "Coins: " + product.GetValue();
        unityEvent.Invoke();
    }
}
