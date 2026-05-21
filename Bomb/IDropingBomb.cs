using System.Collections.Generic;
using UnityEngine;

namespace Bomb
{
    public interface IDropingBomb
    {
        void PlayerDroppingBomb(GameObject prefabBomb, Transform playerPosition, int lvlPlayer, int valueBomb);
    }
}