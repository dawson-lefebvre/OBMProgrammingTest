using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispelMagicSpell : BaseSpell
{
    public override void UseSpell(RPGCharacter character)
    {
        //No need to use base because we aren't adding it to the player
        foreach(BaseSpell s in character.activeSpells)
        {
            s.CancelSpell(character);
        }
    }
}
