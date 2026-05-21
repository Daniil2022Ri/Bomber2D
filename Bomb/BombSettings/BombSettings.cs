using System;
using Player;
using UnityEngine;

namespace Bomb
{
    public class BombSettings : MonoBehaviour
    {
        [Header("Префаб бомбы")] 
        [SerializeField] GameObject prefabBomb;

        [Header("Параметры бомбы")] [Header("Время до взрыва бомбы")] 
        [SerializeField] [Range(2, 5)] private float timeExplosionBomb;

        [Header("Мощность взрыва в Тайлах - Клетка")] 
        [SerializeField] [Range(1, 20)] private int rangeExplosionBomb;

        [Header("Наносимый бомбой урон")]
        [SerializeField] [Range(25, 50)] private float bombDamagePlayer;

        [Header("Спрайт Взрыва")] 
        [SerializeField] private GameObject explosionSprite;

        [Header("Указания препятствия")] 
        [SerializeField] private LayerMask wallLayer;

        private RaycastHit2D raycastHit2D;

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

        public GameObject GetBombPrefab => prefabBomb;
    }
}