using UnityEngine;

namespace Assets.Breakout.Scripts
{
    public class Paddle : MonoBehaviour
    {
        private float _lastHitPos;
        private RaycastHit _hit;
        private Ray _ray;
	
        void FixedUpdate ()
        {
            _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(_ray, out _hit))
            {
                _lastHitPos = _hit.point.x;
            }
            transform.position = new Vector3(_lastHitPos, -4f, 0f);
        }
    }
}
