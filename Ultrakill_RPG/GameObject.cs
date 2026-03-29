using System;

namespace Ultrakill_RPG
{
    public class GameObject
    {

        protected string name;
        protected double resistance;
        protected double health;
        protected double maxHealth;
        public double damageTaken;

        public List<AttackType> attackList;

        protected string UI_statusName;
        /// <summary>
        /// Updated the GameObject name and enterpolates the health for display in the UI.
        /// </summary>
        /// <returns>String that is the name.</returns>
        public string UI_nameAndStatus_Update()
        {
            return this.UI_statusName = $"{name} Health: {health}";
        }
        public void DealDamage(GameObject attackerObject, GameObject selectedObject, AttackType selectedAttack)
        {
            selectedObject.TakeDamage(selectedObject.GetResistance(), selectedAttack.GetAttackDamage());
            if (attackerObject.GetName() == "v1")
            {
                attackerObject.V1Heal(attackerObject);
            }
        }
        public double TakeDamage(double resistance, double incomingAttackDamage)
        {
            this.health = this.health - AttackType.FinalDamageCheck(resistance, incomingAttackDamage);
            this.damageTaken = AttackType.FinalDamageCheck(resistance, incomingAttackDamage);
            UI_nameAndStatus_Update();
            if (this.health < 0)
            {
                this.health = 0;
            }
            return this.health;
        }
        public double V1Heal(GameObject v1) 
        {
            this.health = this.health + Math.Round(((v1.maxHealth/3) * 100), 2);
            if (this.health > maxHealth)
            {
                return this.health = maxHealth;
            }
            else 
            {
                return this.health;
            }
        }
        public GameObject(string name, double resistance, double health, double maxHealth, List<AttackType> attackList)
        {
            this.name = name;
            this.resistance = resistance;
            this.health = health;
            this.attackList = attackList;
        }
        /// <summary>
        /// Gets the GameObject name
        /// </summary>
        /// <returns>The GameObject name.</returns>
        public string GetName()
        {
            return this.name;
        }
        /// <summary>
        /// Gets the GameObject resistance
        /// </summary>
        /// <returns>The GameObject resistance.</returns>
        public double GetResistance()
        {
            return this.resistance;
        }
        /// <summary>
        /// Gets the GameObject health
        /// </summary>
        /// <returns>The GameObject health.</returns>
        public double GetHealth()
        {
            return this.health;
        }
        /// <summary>
        /// Gets the GameObject stats in a string format for display in the UI.
        /// </summary>
        /// <returns>A string containing the GameObject's stats.</returns>
        public string GetStats()
        {
            return $"Health: {this.health}\nResistance: {this.resistance}\n";
        }
        /// <summary>
        /// Gets the GameObject's name and health in a string format for display in the UI.
        /// </summary>
        /// <returns>A string containing the GameObject's name and health.</returns>
        public string GetUIStatusName()
        {
            return this.UI_statusName;
        }
        public List<AttackType> GetAttackList()
        {
            return attackList;
        }
    }
}