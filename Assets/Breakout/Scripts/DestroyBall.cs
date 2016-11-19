using UnityEngine;

namespace Assets.Breakout.Scripts
{
    public class DestroyBall : MonoBehaviour
    {
        void OnCollisionEnter(Collision coll)
        {
            GameObject go = coll.gameObject;
            Instantiate(go, Vector3.zero, Quaternion.identity);
            Destroy(coll.gameObject);
        }
    }
}
