using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropingBomb : MonoBehaviour
{
    [Header("Скрипт работы с бомбами игрока (Выбрасывает)")]
    
    [Header("Префаб Бомбы")]
    [SerializeField] private GameObject bombPrefab;
    
    [Header("Сколько бомб в инвентаре у игрока")]
    [SerializeField][Range(0 , 5)] private int numberBombInventory;

    [Header("Время пополнения бомб в инвентаре")]
    [SerializeField][Range(1,5)]private float timeUpdateBombsInventory;
    
    [Header("Позиция откуда спавнится бомба")]
    [SerializeField] private Transform playerPositionDropingPoint;

    [Header("Место откуда произойдет взрыв бомбы")]
    [SerializeField] private Transform pointToExplousionBomb;
    
    [Header("Время до взрыва бомбы")]
    [SerializeField][Range(2,5)] private float timeToExplousionBomb;
    
    [Header("Размер взрыва бомбы")]
    [SerializeField][Range(1,10)] private float tileExplousionBomb;
    
    [Header("Управление")]
    [SerializeField] private KeyCode dropKey = KeyCode.Space; 
    
    private const int ChekingNullInt = 0;
    private const int NewBombFromInventory = 1;
    void Start()
    {
        _chekingSettingsScriptDropingBomb();
    }

    
    void Update()
    {
        _dropingBombFromPlayer(playerPositionDropingPoint ,bombPrefab, numberBombInventory );
    }

    private void _chekingSettingsScriptDropingBomb()
    {
        if (bombPrefab.gameObject == null)
        {
            Debug.Log("Нужно добавить префаб бомбы в скрипт DropingBomb");
        }
    }
    private void _dropingBombFromPlayer( Transform positionPlayer, GameObject prefabBomb , int bombInventory)
    {
        if (bombInventory != ChekingNullInt || Input.GetKeyDown(dropKey))
        {
            GameObject newBomb = Instantiate(prefabBomb ,  positionPlayer.position, Quaternion.identity);
            bombInventory--;
        }
    }

    private int reloadBombInventory(int bombInventory)
    {
        
        return bombInventory += NewBombFromInventory;
    }
}
