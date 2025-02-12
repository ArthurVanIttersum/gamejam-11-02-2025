using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityFundamentals;

public class SetBulk : MonoBehaviour
{
    public Slider bulkSlider;
    public float sliderValue;

    private void Update()
    {
        sliderValue = bulkSlider.value;
    }

    public float GetSliderValue()
    {
        return sliderValue;
    }

}
