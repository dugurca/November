using UnityEngine;

namespace Assets._Project.Scripts.Day2
{
    public class HelloAwakeStart : MonoBehaviour
    {
        void Awake()
        {
            Debug.Log("Awake call");
        }

        void Start ()
        {
            Debug.Log("Start call");
        }


        void FixedUpdate()
        {
            Debug.Log("FixedUpdate time :" + Time.deltaTime);
        }


        void Update()
        {
            Debug.Log("Update time :" + Time.deltaTime);
        }
    }
}
