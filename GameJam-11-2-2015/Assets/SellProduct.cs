using Unity.VisualScripting;
using UnityEngine;
using UnityFundamentals;

public class SellProduct : MonoBehaviour
{
    public IntVariable milk;
    public IntVariable butter;
    public IntVariable cheese;
    public IntVariable cake;
    public IntVariable coins;

    public void sellMilk()
    {
        coins.ChangeValueBy(1 * milk.GetValue());
        milk.ChangeValueTo(0);
    }

    public void sellButter()
    {
        coins.ChangeValueBy(2 * butter.GetValue());
        butter.ChangeValueTo(0);
    }
    public void sellCheese()
    {
        coins.ChangeValueBy(4 * cheese.GetValue());
        cheese.ChangeValueTo(0);
    }
    public void sellCake()
    {
        coins.ChangeValueBy(8 * cake.GetValue());
        cake.ChangeValueTo(0);
    }
}
