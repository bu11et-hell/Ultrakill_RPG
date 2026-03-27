using System;
using System.Collections.Generic;
using System.Text;

namespace Ultrakill_RPG
{
    public class AttackType
    {
      protected string name;
      protected double damageDealth;

      public AttackType(string name, double damageDealth) {
        this.name = name;
        this.damageDealth = damageDealth;
      }
      public string GetAttackName(){
        return this.name;
      }

      public double GetAttackDamage(){
        return this.damageDealth;
      }
    }
}
