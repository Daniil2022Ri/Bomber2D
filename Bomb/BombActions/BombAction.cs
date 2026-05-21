using System;
using System.Collections.Generic;
using Player;
using UnityEngine;

namespace Bomb
{
    public class BombAction : MonoBehaviour , IDropingBomb
    {

        private BombSettings _bombSettings;
        private PlayerSettings _playerSettings;

        private void Start()
        {
            _bombSettings = GetComponent<BombSettings>();
            _playerSettings = GetComponent<PlayerSettings>();
        }

        private void Update()
        {
            PlayerDroppingBomb(_bombSettings.GetBombPrefab, _playerSettings.GetPositionDropingBomb , _playerSettings.GetPlayerMax , _playerSettings.NumberBombPlayerInventory);
        }

        public void PlayerDroppingBomb(GameObject prefabBomb, Transform playerPosition, int lvlPlayer , int valueBomb)
        {
            if (prefabBomb != null && valueBomb != 0 && Input.GetKeyDown(KeyCode.Space))
            {
                switch (lvlPlayer)
                    {
                        case 1: 
                            Instantiate(prefabBomb, playerPosition.position, Quaternion.identity);
                            valueBomb--;
                            break;
                        case 2: 
                            Instantiate(prefabBomb, playerPosition.position, Quaternion.identity);
                            valueBomb--;
                            break;
                        case 3: 
                            Instantiate(prefabBomb, playerPosition.position, Quaternion.identity);
                            valueBomb--;
                            break;
                        case 4: 
                            Instantiate(prefabBomb, playerPosition.position, Quaternion.identity);
                            valueBomb--;
                            break;
                    }
            }
         
        }

        
        
    }
}