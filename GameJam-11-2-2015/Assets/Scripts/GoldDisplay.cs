using UnityEngine;
using UnityFundamentals;

public class GoldDisplay : MonoBehaviour
{
    public IntVariable money;
    public GameObject[] goldPots;
    private GameObject currentGoldPot;
    public Vector3 goldPotPosition;
    public int currentValue = 10;
    public int[] thresholds;

    void Start()
    {
        TryUpdateGoldDisplay();
        //SwitchModel(0);
    }

    public void TryUpdateGoldDisplay()
    {
        int newValue = 0;
        if (money.GetValue() > thresholds[0])
        {
            newValue = 1;
        }
        if (money.GetValue() > thresholds[1])
        {
            newValue = 2;
        }
        if (money.GetValue() > thresholds[2])
        {
            newValue = 3;
        }
        if (money.GetValue() > thresholds[3])
        {
            newValue = 4;
        }
        if (money.GetValue() > thresholds[4])
        {
            newValue = 5;
        }
        if (money.GetValue() > thresholds[5])
        {
            newValue = 6;
        }
        if (money.GetValue() > thresholds[6])
        {
            newValue = 7;
        }
        
        if (currentValue != newValue)
        {
            SwitchModel(newValue);
        }
        currentValue = newValue;
    }

    private void SwitchModel(int goldDisplayValue)
    {
        
        if (currentGoldPot != null)
        {
            Destroy(currentGoldPot);
        }
        currentGoldPot = Instantiate(goldPots[goldDisplayValue], goldPotPosition, Quaternion.identity, transform);
    }
}
