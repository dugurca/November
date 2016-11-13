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
        
        void Update()
        {
            Debug.Log("Time: " + Time.time);
            Debug.Log("Update time :" + Time.deltaTime);
        }

        void FixedUpdate()
        {
            Debug.Log("FixedUpdate time :" + Time.deltaTime);
        }
    }
}
