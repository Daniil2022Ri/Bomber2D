using System;
using Player.PlayerAnimation;
using UnityEngine;
using VContainer;

namespace Player.PlayerAction
{
    public class PlayerActionMoving : MonoBehaviour
    { 
        
        private PlayerController _playerController; 
        private PlayerSettings _playerSettings;
        

        private void Start()
        {
            _playerController = GetComponent<PlayerController>();
            _playerSettings = GetComponent<PlayerSettings>();
        }

        private void Update()
        {
            _playerController.PlayerMoving(_playerSettings.PlayerController ,_playerSettings.GetMoveSpeed );
        }
    }
}