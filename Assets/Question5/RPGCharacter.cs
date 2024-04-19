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
    int levelUpExp = 1000; //Amount of exp needed to level up

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
        int previousExp = totalExperience;

        totalExperience += gainedExp;

        //Check if exp is enough to level up
        if(totalExperience >= levelUpExp * currentLevel)
        {
            //How many levels to level up
            int levels = totalExperience - (levelUpExp * currentLevel - 1) / levelUpExp;

            for (int i = 0; i < levels; i++)
            {
                LevelUp();
            }
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
