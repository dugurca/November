using UnityEngine;

namespace Assets._Project.Scripts.Day2
{
    public class RandomColored : MonoBehaviour
    {
        public PhysicMaterial PhysMat;
	
        void Update () {
            GameObject randomSphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            randomSphere.AddComponent<Rigidbody>();
            randomSphere.GetComponent<SphereCollider>().material = PhysMat;
            randomSphere.GetComponent<Renderer>().material.color =
                new Color(Random.value, Random.value, Random.value);
        }
    }
}
