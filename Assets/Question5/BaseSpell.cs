using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSpell
{
    public int turnsRemaining;
    public virtual void UseSpell(RPGCharacter character)
    {
        character.activeSpells.Add(this);
    }

    public virtual void CancelSpell(RPGCharacter character)
    {
        character.activeSpells.Remove(this);
    }

    public virtual void TurnEffect(RPGCharacter character)
    {
        turnsRemaining--;
        if(turnsRemaining <= 0)
        {
            CancelSpell(character);
        }
    }
}
