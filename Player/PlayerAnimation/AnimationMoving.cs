using System;
using TMPro;
using UnityEngine;
using VContainer;

namespace Player.PlayerAnimation
{
    public class AnimationMoving :  MonoBehaviour
    {
        private PlayerSettings _playerSettings;
        //[SerializeField]private PlayerSettings  _playerSettings;
        

        private void Start()
        {
            _playerSettings = GetComponent<PlayerSettings>();
        }

        private void Update()
        {
            TakeAnimation(_playerSettings.PlayerSpriteUp , _playerSettings.PlayerSpriteDown , _playerSettings.PlayerSpriteLeft ,  _playerSettings.PlayerSpriteRight );
        }

        public void TakeAnimation(SpriteRenderer forward , SpriteRenderer backward , SpriteRenderer left,SpriteRenderer right)
        {
            if (Input.GetKey(KeyCode.W))
            {
                forward.enabled = true;
                backward.enabled = false;
                left.enabled = false;
                right.enabled = false;
            }

            if (Input.GetKey(KeyCode.S))
            {
                forward.enabled = false;
                backward.enabled = true;
                left.enabled = false;
                right.enabled = false;
            }

            if (Input.GetKey(KeyCode.A))
            {
                forward.enabled = false;
                backward.enabled = false;
                left.enabled = true;
                right.enabled = false;
            }

            if (Input.GetKey(KeyCode.D))
            {
                forward.enabled = false;
                backward.enabled = false;
                left.enabled = false;
                right.enabled = true;
            }
        }
        
        
       
        
    }
}