using UnityEngine;

namespace Bomb
{
    public interface IExplosion
    {
        void TileExplosion(Vector3 vectorExplosion, int lvlBomb, GameObject prefabExplosion, Transform positionStartExplosion , RaycastHit2D hit2D);
        void DestroyGameObjectBomb(GameObject bombPrefab, float timeExplosionBomb);
    }
}