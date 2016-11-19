using UnityEngine;

namespace Assets.Breakout.Scripts
{
    public class MakeZAxisZero : MonoBehaviour
    {
        private Vector3 _oldPos;

        void FixedUpdate()
        {
            _oldPos = transform.position;
            transform.position = new Vector3(_oldPos.x, _oldPos.y, 0f);
        }
    }
}
