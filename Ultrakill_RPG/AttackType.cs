using System;
using System.Collections.Generic;
using System.Text;

namespace Ultrakill_RPG
{
    /// <summary>
    /// DataType class for attacks.
    /// </summary>  
    public class AttackType
    {
        protected string name;
        protected double damageDealth;

        /// <summary>
        /// Constructor for the AttackType class.
        /// </summary>
        /// <param name="name">Name of the attack.</param>
        /// <param name="damageDealth">Damage dealt by the attack.</param>
        public AttackType(string name, double damageDealth) {
            this.name = name;
            this.damageDealth = damageDealth;
        }
        /// <summary>
        /// Gets the attack name
        /// </summary>
        /// <returns>String</returns>
        public string GetAttackName(){
            return this.name;
        }

        /// <summary>
        /// Gets the attack damage
        /// </summary>
        /// <returns>Double</returns>
        public double GetAttackDamage(){
            return this.damageDealth;
        }
    }
}
