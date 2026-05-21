
using System;
using System.Collections.Generic;
using Bomb;
using UnityEngine;

namespace Player
{
    public class PlayerSettings : MonoBehaviour 
    {
       [Header("Настройки Игрока 2Д")]
       
       [Header("Спрайты Передвижения по плоскости")]
       [SerializeField]private SpriteRenderer playerSpriteUP;
       [SerializeField]private SpriteRenderer playerSpriteDOWN;
       [SerializeField]private SpriteRenderer playerSpriteLEFT;
       [SerializeField]private SpriteRenderer playerSpriteRIGHT;

       [Header("Цвет команды")] 
       [SerializeField] private Color TeamBlue =  Color.blue;
       [SerializeField] private Color TeamRed =  Color.red;
       [SerializeField] private Color TeamYelow =  Color.yellow;
       [SerializeField] private Color TeamGreen =  Color.green;

       [Header("Цвет команды выбор")] 
       [SerializeField] private bool playerTeamBlue;
       [SerializeField] private bool playerTeamRed;
       [SerializeField] private bool playerTeamYellow;
       [SerializeField] private bool playerTeamGreen;
       
       [Header("Контроллер игрока")]
       [SerializeField] private CharacterController playerController;

       [Header("Здоровье игрока")]
       [SerializeField] [Range(0, 100)] private float healthPlayer;
       
       [Header("Скорость передвижения игрока")]
       [SerializeField][Range(1, 5)] private float moveSpeed;
       
       [Header("Уровень игрока")]
       [SerializeField] [Range(1, 5)] private int lvlPlayerMax;

       

       [Header("Колличество бомб в инвентаре")]
       [SerializeField] [Range(1, 5)] private int numberBombPlayerInventory;

   


       [Header("Система использования бомб")] 
       
       [Header("Позиция с которой спавнится бомба")]
       [SerializeField] private Transform positionDropingBomb;

       [Header("Кнопка на которую выбрасывается бомба")]
       [SerializeField] private KeyCode dropintBombKey = KeyCode.Space;
       
      
       

       private Vector3 movingPlayer;
       private const int LvlPlayerUpdate = 1;
        

            
       
            public SpriteRenderer PlayerSpriteUp => playerSpriteUP;
     
            public SpriteRenderer PlayerSpriteDown => playerSpriteDOWN;
     
            public SpriteRenderer PlayerSpriteLeft => playerSpriteLEFT;
     
            public SpriteRenderer PlayerSpriteRight => playerSpriteRIGHT;
      
            public CharacterController PlayerController => playerController;
            
            public float GetMoveSpeed =>  moveSpeed;
            public int GetPlayerMax => lvlPlayerMax;
            public int NumberBombPlayerInventory
            {
                get => numberBombPlayerInventory;
                set => numberBombPlayerInventory = value;
            }
          
            public Transform GetPositionDropingBomb => positionDropingBomb;

    }
}