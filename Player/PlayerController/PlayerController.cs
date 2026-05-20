using System;
using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    private SettingsConstantsGame _constantsGame;
    

    private void Start()
    {
        _constantsGame = new SettingsConstantsGame();
    }

    public void PlayerMoving(CharacterController controllerPlayer , float moveSpeed)
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        
        Vector3 movingPlayer = new Vector3(horizontal, vertical, 0);
        
        controllerPlayer.Move(movingPlayer * moveSpeed * Time.deltaTime);
    }

    public void PlayerDropingBomb(Transform playerDropingPosition, GameObject prefabBomb , int ValueBombInventory)
    {
        if (ValueBombInventory != 0)
        {
            Instantiate(prefabBomb , playerDropingPosition.position, Quaternion.identity);
            ValueBombInventory--;
        }
    }
    
    
  
}
