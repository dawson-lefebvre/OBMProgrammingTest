using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OgreStrengthSpell : BaseSpell
{
    public override void UseSpell(RPGCharacter character)
    {
        base.UseSpell(character);
        character.baseStrength *= 2;
        character.currentStrength = character.baseStrength;
    }

    public override void CancelSpell(RPGCharacter character)
    {
        character.baseStrength /= 2;
        character.currentStrength = character.baseStrength;
        base.CancelSpell(character);
    }
}
