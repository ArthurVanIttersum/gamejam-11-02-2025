using UnityEngine;
using UnityFundamentals;

public class GoldDisplay : MonoBehaviour
{
    public IntVariable money;
    public GameObject[] goldPots;
    private GameObject currentGoldPot;
    public Vector3 goldPotPosition;
    public int currentValue;
    public int[] thresholds;
    
    public void TryUpdateGoldDisplay()
    {
        int newValue = 0;
        if (money.GetValue() < thresholds[0])
        {
            newValue = 1;
        }
        else if (money.GetValue() < thresholds[1])
        {
            newValue = 2;
        }
        else if (money.GetValue() < thresholds[2])
        {
            newValue = 3;
        }
        else if (money.GetValue() < thresholds[3])
        {
            newValue = 4;
        }
        else if (money.GetValue() < thresholds[4])
        {
            newValue = 5;
        }
        else if (money.GetValue() < thresholds[5])
        {
            newValue = 6;
        }
        else if (money.GetValue() < thresholds[6])
        {
            newValue = 7;
        }
        
        if (currentValue != newValue)
        {
            SwitchModel(newValue);
        }
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
