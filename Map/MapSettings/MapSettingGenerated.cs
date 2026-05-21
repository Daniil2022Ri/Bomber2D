using System;
using System.Collections.Generic;
using UnityEngine;

namespace Map.MapSettings
{
    public class MapSettingGenerated :  MonoBehaviour
    {
        
        [SerializeField] private List<GameObject> prefabPlayer;
        [SerializeField] private List<GameObject> prefabBot;
        [SerializeField] private List<Transform> positionSpawn;
        


        private void Start()
        {
            prefabPlayer.Add(GameObject.FindGameObjectWithTag("Player"));
            prefabBot.Add(GameObject.FindGameObjectWithTag("Bot"));
            positionSpawn.Add(GameObject.FindGameObjectWithTag("SpawnPoint").transform);
        }
    }
}