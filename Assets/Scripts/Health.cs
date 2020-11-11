using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
   public int maxHealth;
    public Text currentHealthLabel;
    private int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        UpdateGUI();
    }

    void UpdateGUI(){
        currentHealthLabel.text = currentHealth.ToString();
    }

    public void AlterHealth(int amount){
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateGUI();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
