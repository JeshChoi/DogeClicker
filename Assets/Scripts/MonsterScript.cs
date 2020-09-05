using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MonsterScript : MonoBehaviour
{

    public static int maxHealth = 20;
    public int displayHealth;
    public static int currentHealth;
    public AudioSource playSound;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

    }
    
    public void TakeDamage()
    {
        if(currentHealth > 0)
        {
            playSound.Play();
            currentHealth -= GlobalStats.PlayerDmg;
            healthBar.SetHealth(currentHealth);
            GlobalStats.PlayerCash += 1;
        }
        if(currentHealth <= 0)
        {
            SceneTransferScript.GoToDeathScene();
        }
    }

    public void FeedDog() //heal dog // need to buy dog food
    {
        if (GlobalStats.NumOfFood > 0)
        {//dog is healed 2 health but the player loses 1 feed point, which is NumOfFood
            currentHealth += 2;//edit this to a lower feed power later: EDITT TO A DIFFERENT VAIRABLE
            healthBar.SetHealth(currentHealth);
            GlobalStats.NumOfFood -= 1;
        }
        if (currentHealth > maxHealth)
        {
            healthBar.SetHealth(maxHealth);

        }
    }

    public void PetDog() //dog gives memes in return for head pats
    {

    }
    // Update is called once per frame
    void Update()
    {
    //    displayHealth = currentHealth;
    }
}
