using System;
using System.Collections.Generic;
using System.Text;

namespace Ultrakill_RPG
{
    public class AttackType
    {
      protected string name;
      protected int damageDealth;

      public Attack(string name, int damageDealth) {
        this.name = name;
        this.damageDealth = damageDealth;
      }

      public string GetAttackName(){
        return this.name;
      }

      public int GetAttackDamage(){
        return this.damageDealth;
      }
    }
}
