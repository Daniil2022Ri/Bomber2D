using System;
using System.Collections.Generic;
using BlockOfDestroy;
using UnityEngine;

namespace BlocksScripts.BlockOfDestroy
{
    public class DestoryBlock : MonoBehaviour
    {
        private BlockSettings _blockSettings;
        private void Start()
        {
            _blockSettings = GetComponent<BlockSettings>();
        }

        private void Update()
        {
            
        }

        public void GetDestoryBlock(GameObject blockDestroy, List<GameObject> dropItems, RaycastHit2D hit2D,
            float changeDropItems)
        {
            
        }
        
    }
}