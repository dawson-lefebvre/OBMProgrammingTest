using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaknessSpell : BaseSpell
{
    int minTurns, maxTurns;
    public override void UseSpell(RPGCharacter character)
    {
        base.UseSpell(character);
        turnsRemaining = Random.Range(minTurns, maxTurns + 1);
    }

    public override void TurnEffect(RPGCharacter character)
    {
        character.currentStrength -= 5;
        character.maxHealth -= 5;

        if(character.currentHealth > character.maxHealth)
        {
            character.currentHealth = character.maxHealth;
        }

        base.TurnEffect(character);
    }
}
