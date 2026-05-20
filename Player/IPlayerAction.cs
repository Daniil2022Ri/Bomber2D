using UnityEngine;

namespace Player
{
    public interface IPlayerAction
    {
        void Move(Vector3 movement , CharacterController playerController , float moveSpeed);
    }
}