using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGCharacter
{
    public int maxHealth;
    public int currentHealth;

    public int baseStrength;
    public int currentStrength;

    int totalExperience;
    int currentLevel;
    int baseLevelUpExp = 1000;
    int currentLevelUpExp = 1000; //Amount of exp needed to level up

    public List<BaseSpell> activeSpells = new List<BaseSpell>();
    public void TakeTurn()
    {
        foreach (BaseSpell spell in activeSpells)
        {
            spell.TurnEffect(this);
        }
    }

    public void ApplyDamage(int damage)
    {
        currentHealth -= damage;

        if(currentHealth <= 0)
        {
            //Implement some sort of death mechanic
        }
    }

    public void GainExperience(int gainedExp)
    {
        totalExperience += gainedExp;

        currentLevelUpExp -= gainedExp;

        while(currentLevelUpExp > 0) //Is it enough to level up?
        {
            LevelUp();
            int expOverLevel = Mathf.Abs(currentLevelUpExp); //Get the overage
            currentLevelUpExp = baseLevelUpExp; //Reset value
            currentLevelUpExp -= expOverLevel; //Subtract overage 
        }
    }

    public void UpdatedGainExp(int gainedExp)
    {
        totalExperience += gainedExp;

        currentLevelUpExp -= gainedExp;

        while (currentLevelUpExp > 0) //Is it enough to level up?
        {
            LevelUp();
            int expOverLevel = Mathf.Abs(currentLevelUpExp); //Get the overage
            currentLevelUpExp = currentLevel * baseLevelUpExp; //Reset value
            currentLevelUpExp -= expOverLevel; //Subtract overage 
        }
    }

    void LevelUp()
    {
        currentLevel++;
        maxHealth += 10;
        baseStrength += 1;
    }

    public int GetBaseStrength()
    {
        return baseStrength;
    }

    public int GetCurrentStrength()
    {
        return currentStrength;
    }
}
