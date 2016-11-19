using UnityEngine;

namespace Assets.Breakout.Scripts
{
    public class DestroyWhenBallHits : MonoBehaviour
    {
        void OnCollisionEnter(Collision coll)
        {
            GameObject go = coll.collider.gameObject;
            if (go.tag.Equals("Ball"))
            {
                Destroy(gameObject);
            }
        }
    }
}
