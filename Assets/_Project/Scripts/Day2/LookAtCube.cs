using UnityEngine;

namespace Assets._Project.Scripts.Day2
{
    public class LookAtCube : MonoBehaviour
    {
        public Transform Target;

        void Update () {
            transform.LookAt(Target);
        }
    }
}
