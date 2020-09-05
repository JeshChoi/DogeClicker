using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOptionScript : MonoBehaviour
{
   
    public void BuyBurger()
    {
        if(GlobalStats.PlayerCash >= 5)
        {
            GlobalStats.NumOfFood += 1;
            GlobalStats.PlayerCash -= 5;
        }
    }
}
