using UnityEngine;

namespace Map
{
    public class LayersWall :  MonoBehaviour
    {
        [Header("Script работы с распознованием стены")]
        [SerializeField] private LayerMask layerMaskWall;
        [SerializeField] private RaycastHit2D _hit2D;
    }
}