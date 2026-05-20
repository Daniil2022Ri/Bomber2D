using System;
using Player;
using UnityEngine;

namespace Bomb
{
    public class BombSettings : MonoBehaviour, IExplosion , ISpawnBomb
    {
        [Header("Префаб бомбы от Настроек игрока")] [SerializeField]
        PlayerSettings playerSettings;

        [Header("Параметры бомбы")] [Header("Время до взрыва бомбы")] 
        [SerializeField] [Range(2, 5)] private float timeExplosionBomb;

        [Header("Мощность взрыва в Тайлах - Клетка")] [SerializeField] [Range(1, 20)]
        private int rangeExplosionBomb;

        [Header("Наносимый бомбой урон")] [SerializeField] [Range(25, 50)]
        private float bombDamagePlayer;

        [Header("Спрайт Взрыва")] [SerializeField]
        private GameObject explosionSprite;

        [Header("Указания препятствия")] [SerializeField]
        private LayerMask wallLayer;

        [SerializeField] private RaycastHit2D raycastHit2D;

        private Vector3 vectorExpl;

        //Getting all settings
        public RaycastHit2D GetBombSettingsRaycast()
        {
            return raycastHit2D;
        }

        public LayerMask GetBombSettingsLayer()
        {
            return wallLayer;
        }

        public float GetBombDamagePlayer()
        {
            return bombDamagePlayer;
        }

        public int GetRangeExplosionBomb()
        {
            return rangeExplosionBomb;
        }

        public float GetTimeExplosingBomb()
        {
            return timeExplosionBomb;
        }

    
        
        public void playerDropBomb(GameObject prefabBomb, Transform playerPosition, KeyCode keyCodeSpace)
        {
            if (keyCodeSpace == KeyCode.Space)
            {
                Vector3 playerPos = playerPosition.position;
                Instantiate(prefabBomb, playerPos, Quaternion.identity);
                
            }
        }

        public void TileExplosion(Vector3 vectorExplosion, int lvlBomb, GameObject prefabExplosion,
            Transform positionStartExplosion, RaycastHit2D raycastHit2D)
        {
            // Полная пизда нужно условия иначе игра зависнет нахуй

            Vector3 centerExplosion = positionStartExplosion.position;

            if (prefabExplosion == null)
            {
                Debug.Log("Нет Префаба взрыва");
            }
            else
            {
                Instantiate(prefabExplosion, centerExplosion, Quaternion.identity);
                Vector3[] directions = { Vector3.up, Vector3.right, Vector3.left };
                foreach (Vector3 dir in directions)
                {
                    RaycastHit2D hit = Physics2D.Raycast(centerExplosion, dir, lvlBomb, wallLayer);

                    // Определяем дистанцию до остановки взрыва
                    // Если стена есть -> взрываем до стены. Если нет -> на всю длину lvlBomb
                    float distanceToStop = hit.collider != null ? hit.distance : lvlBomb;

                    // Если попали в стену, округляем вниз, чтобы не создать тайл ВНУТРИ стены
                    if (hit.collider != null)
                    {
                        distanceToStop = Mathf.Floor(hit.distance);
                    }

                    // Рисуем луч в редакторе (ВИДИМОСТЬ ЛУЧА)
                    // Цвет красный, длительность 2 секунды, толщина линии 0 (в Scene view линии всегда тонкие, но Gizmos могут быть толще)
                    Debug.DrawRay(centerExplosion, dir * distanceToStop, Color.yellow, 4f);

                    // Цикл создания тайлов ТОЛЬКО до препятствия
                    for (int i = 1; i <= distanceToStop; i++)
                    {
                        Vector3 spawnPos = centerExplosion + (dir * i);
                        Instantiate(prefabExplosion, spawnPos, Quaternion.identity);
                    }
                }

            }
        }

        public void DestroyGameObjectBomb(GameObject bombPrefab, float timeExplosionBomb)
        {
            
        }
       
    }
}