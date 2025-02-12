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
        productText.text = product.name + ": " + product.GetValue();
        unityEvent.Invoke();
    }
}
