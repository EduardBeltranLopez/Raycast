using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tombstone_Life : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth = 1000;
    private float enemyDamage = 20;

    public Image barraSalud;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        TakeDamage();
    }

    // Update is called once per frame
    void Update()
    {
        TakeDamage();
    }



    void TakeDamage()
    {
        barraSalud.fillAmount = currentHealth / maxHealth;

        if (Input.GetKeyDown(KeyCode.Space) && currentHealth > 0)
        {
            currentHealth = currentHealth - enemyDamage;
        }
    }

    
}
