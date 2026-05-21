using System.Collections.Generic;
using UnityEngine;

namespace Bomb
{
    public interface IExplosion
    {

        void BombExplose(List<GameObject>prefabBomb,List<GameObject>prefabExplose ,Transform positionPrefabBomb, RaycastHit2D raycastHit);
        
        
    }
}