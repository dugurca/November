using UnityEngine;

namespace Assets.Breakout.Scripts
{
    public class AddInitialForce : MonoBehaviour
    {
        // Use this for initialization
        void Start ()
        {
            var startForce = new Vector3(Random.Range(-5, 5), 10, 0);
            GetComponent<Rigidbody>().velocity = startForce;
        }
    }
}
