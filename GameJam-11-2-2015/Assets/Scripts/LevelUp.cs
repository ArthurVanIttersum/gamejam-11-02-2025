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

    public GameObject[] butterRelatedUI;
    public GameObject[] cheeseRelatedUI;
    public GameObject[] cakeRelatedUI;

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
                EnableObjects();
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

    public void EnableObjects()
    {
        if (currentLevel == 1)
        {
            for (int i = 0; i < butterRelatedUI.Length; i++)
            {
                butterRelatedUI[i].SetActive(true);
            }
        }
        else if (currentLevel == 2)
        {
            for (int i = 0; i < cheeseRelatedUI.Length; i++)
            {
                cheeseRelatedUI[i].SetActive(true);
            }
        }
        else if (currentLevel == 3)
        {
            for (int i = 0; i < cakeRelatedUI.Length; i++)
            {
                cakeRelatedUI[i].SetActive(true);
            }
        }

    }
}
