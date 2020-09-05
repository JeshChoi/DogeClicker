using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalStats : MonoBehaviour
{
    public static int PlayerDmg = 2;
    public static int PlayerCash = 0;
    public static int NumOfSwords = 0;
    public static int NumOfFood = 5;//should be 0, i am just testing
    public static int feedPower = 1;
    public static int petPower = 1;

    public GameObject cashText;
    public GameObject foodText;

    //Create a restart method



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cashText.GetComponent<Text>().text = PlayerCash.ToString();
        foodText.GetComponent<Text>().text = NumOfFood.ToString();
    }
}
