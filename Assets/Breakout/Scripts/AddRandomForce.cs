using UnityEngine;

namespace Assets.Breakout.Scripts
{
    public class AddRandomForce : MonoBehaviour
    {
        void FixedUpdate()
        {
            GetComponent<Rigidbody>().AddForce(Random.value, Random.value, 0);
        }
    }
}
