using UnityEngine;

namespace Assets._Project.Scripts.Day2
{
    public class DestroyWhenTouch : MonoBehaviour {
        void OnCollisionEnter(Collision coll)
        {
            Destroy(coll.gameObject);
        }
    }
}
