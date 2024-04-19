using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class VigorSpell : BaseSpell
{
    public override void UseSpell(RPGCharacter character)
    {
        base.UseSpell(character);
        character.currentStrength = character.baseStrength + 10;
        turnsRemaining = 5;
    }

    public override void TurnEffect(RPGCharacter character)
    {
        //This ensures that if other strength spells are cast, the +10 modifier is the same
        character.currentStrength = character.baseStrength + 10;

        base.TurnEffect(character);
    }

    public override void CancelSpell(RPGCharacter character)
    {
        character.currentStrength -= 10;
        base.CancelSpell(character);
    }
}
