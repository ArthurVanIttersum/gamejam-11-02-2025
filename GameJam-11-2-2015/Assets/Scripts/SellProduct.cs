using System.ComponentModel;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityFundamentals;

public class SellProduct : MonoBehaviour
{
    public IntVariable milk;
    public IntVariable butter;
    public IntVariable cheese;
    public IntVariable cake;
    public IntVariable coins;

    public int milkSellValue;
    public int butterSellValue;
    public int cheeseSellValue;
    public int cakeSellValue;
    public Slider bulkSlider;
    public TextMeshProUGUI amountToSellText;
    public void sellMilk()
    {
        if (milk != null)
        {
            if (bulkSlider.value == 1 && milk.GetValue() >= 1)
            {
                coins.ChangeValueBy(1 * milkSellValue);
                milk.ChangeValueBy(-1);
            } else if (bulkSlider.value == 2 && milk.GetValue() >= 5)
            {
                coins.ChangeValueBy(5 * milkSellValue);
                milk.ChangeValueBy(-5);
            } else if (bulkSlider.value == 3 && milk.GetValue() >= 10)
            {
                coins.ChangeValueBy(10 * milkSellValue);
                milk.ChangeValueBy(-10);
            } else if (bulkSlider.value == 4 && milk.GetValue() >= 100) 
            {
                coins.ChangeValueBy(100 * milkSellValue);
                milk.ChangeValueBy(-100);
            } 
            else if (bulkSlider.value == 5 && milk.GetValue() >= 1000)
            {
                coins.ChangeValueBy(milk.GetValue() * milkSellValue);
                milk.ChangeValueTo(0);
            }
        }
    }
    public void sellButter()
    {
        if (butter != null)
        {
            if (bulkSlider.value == 1 && butter.GetValue() >= 1)
            {
                coins.ChangeValueBy(1 * butterSellValue);
                butter.ChangeValueBy(-1);
            }
            else if (bulkSlider.value == 2 && butter.GetValue() >= 5)
            {
                coins.ChangeValueBy(5 * butterSellValue);
                butter.ChangeValueBy(-5);
            }
            else if (bulkSlider.value == 3 && butter.GetValue() >= 10)
            {
                coins.ChangeValueBy(10 * butterSellValue);
                butter.ChangeValueBy(-10);
            }
            else if (bulkSlider.value == 4 && butter.GetValue() >= 100)
            {
                coins.ChangeValueBy(100 * butterSellValue);
                butter.ChangeValueBy(-100);
            } 
            else if (bulkSlider.value == 5 && butter.GetValue() >= 1000)
            {
                coins.ChangeValueBy(butter.GetValue() * butterSellValue);
                butter.ChangeValueTo(0);
            }
        }
    }
    public void sellCheese()
    {
        if (cheese != null)
        {
            if (bulkSlider.value == 1 && cheese.GetValue() >= 1)
            {
                coins.ChangeValueBy(1 * cheeseSellValue);
                cheese.ChangeValueBy(-1);
            }
            else if (bulkSlider.value == 2 && cheese.GetValue() >= 5)
            {
                coins.ChangeValueBy(5 * cheeseSellValue);
                cheese.ChangeValueBy(-5);
            }
            else if (bulkSlider.value == 3 && cheese.GetValue() >= 10)
            {
                coins.ChangeValueBy(10 * cheeseSellValue);
                cheese.ChangeValueBy(-10);
            }
            else if (bulkSlider.value == 4 && cheese.GetValue() >= 100)
            {
                coins.ChangeValueBy(100 * cheeseSellValue);
                cheese.ChangeValueBy(-100);
            } 
            else if (bulkSlider.value == 5 && cheese.GetValue() >= 1000)
            {
                coins.ChangeValueBy(cheese.GetValue() * cheeseSellValue);
                cheese.ChangeValueTo(0);
            }
        }
    }
    public void sellCake()
    {
        if (cake != null)
        {
            if (bulkSlider.value == 1 && cake.GetValue() >= 1)
            {
                coins.ChangeValueBy(1 * cakeSellValue);
                cake.ChangeValueBy(-1);
            }
            else if (bulkSlider.value == 2 && cake.GetValue() >= 5)
            {
                coins.ChangeValueBy(5 * cakeSellValue);
                cake.ChangeValueBy(-5);
            }
            else if (bulkSlider.value == 3 && cake.GetValue() >= 10)
            {
                coins.ChangeValueBy(10 * cakeSellValue);
                cake.ChangeValueBy(-10);
            }
            else if (bulkSlider.value == 4 && cake.GetValue() >= 100)
            {
                coins.ChangeValueBy(100 * cakeSellValue);
                cake.ChangeValueBy(-100);
            } 
            else if (bulkSlider.value == 5 && cake.GetValue() >= 1000)
            {
                coins.ChangeValueBy(cake.GetValue() * cakeSellValue);
                cake.ChangeValueTo(0);
            }
        }
    }

    public void UpdateBulkValueDisplay()
    {
        string textToDisplay = null;
        if (bulkSlider.value == 1)
        {
            textToDisplay = "1";
        }
        if (bulkSlider.value == 2)
        {
            textToDisplay = "5";
        }
        if (bulkSlider.value == 3)
        {
            textToDisplay = "10";
        }
        if (bulkSlider.value == 4)
        {
            textToDisplay = "100";
        }
        if (bulkSlider.value == 5)
        {
            textToDisplay = "1000+";
        }

        amountToSellText.text = textToDisplay;
    }
}
