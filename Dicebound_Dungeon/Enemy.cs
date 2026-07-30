using System;
using System.Collections.Generic;
using System.Text;

namespace Dicebound_Dungeon
{
    public class Enemy
    {
        public enum EnemyType
        {
            Skeleton,
            Bandit,
            Dragon
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        public Enemy(EnemyType enemyType)
        {
            switch (enemyType)
            {
                case EnemyType.Skeleton:
                    Name = "Skeleton";
                    Health = 8;
                    Attack = 4;
                    Defense = 2;
                    break;

                case EnemyType.Bandit:
                    Name = "Bandit";
                    Health = 20;
                    Attack = 5;
                    Defense = 2;
                    break;

                case EnemyType.Dragon:
                    Name = "Dragon";
                    Health = 80;
                    Attack = 8;
                    Defense = 8;
                    break;
            }
        }
    }
}
