using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Ultrakill_RPG
{
    /// <summary>
    /// DataType class for attacks.
    /// </summary>  
    public class AttackType
    {
        protected string name;
        protected string massage;
        protected double damage;
        protected double finalDamageValue;

        /// <summary>
        /// Constructor for the AttackType class.
        /// </summary>
        /// <param name="name">Name of the attack.</param>
        /// <param name="damageDealth">Damage dealt by the attack.</param>
        public AttackType(string name, double damage, string massage)
        {
            this.name = name;
            this.massage = massage;
            this.damage = damage;
        }
        /// <summary>
        /// Gets the attack name
        /// </summary>
        /// <returns>String</returns>
        public string GetAttackName()
        {
            return this.name;
        }

        /// <summary>
        /// Gets the attack damage
        /// </summary>
        /// <returns>Double</returns>
        public double GetAttackDamage()
        {
            return this.damage;
        }
        public string GetAttackMassage(AttackType selectedAttack)
        {
            return this.massage;
        }
    }
}
