using UnityEngine;

namespace Bomb
{
    public interface ISpawnBomb
    {
        void playerDropBomb(GameObject prefabBomb, Transform playerPosition, KeyCode keyCodeSpace);
    }
}