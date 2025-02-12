using TMPro;
using UnityEngine;
using UnityFundamentals;

public class LevelUp : MonoBehaviour
{
    public int currentLevel = 0;
    public int []costLevelUp;
    public IntVariable money;
    public ResourceGeneration generator;
    public GameObject []houses;
    private GameObject currentHouse;
    public Vector3 housePosition;
    public TextMeshProUGUI housePriceText;
    
    void Start()
    {
        SwitchModel();
    }
    private void Update()
    {
        housePriceText.text = "Price: " + costLevelUp[currentLevel];
    }

    public void GoLevelUp()
    {
        if (money.GetValue() >= costLevelUp[currentLevel])
        {
            money.ChangeValueBy(-costLevelUp[currentLevel]);
            if (currentLevel == 3)
            {
                print("you won the game!!!");
                //move to win scene
            }
            else
            {
                currentLevel++;
                SwitchModel();
                generator.InitiatePasiveIncome(currentLevel);
            }
        }
    }

    public void SwitchModel()
    {
        if (currentHouse != null)
        {
            Destroy(currentHouse);
        }
        currentHouse = Instantiate(houses[currentLevel], housePosition, Quaternion.identity, transform);
        
    }
}
