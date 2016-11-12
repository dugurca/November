using UnityEngine;

namespace Assets._Project.Scripts.Day2
{
    public class EnableDisableComponent : MonoBehaviour {

        private Light _light;

        void Start()
        {
            _light = GetComponent<Light>();
        }

        void Update()
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                _light.enabled = false;
            }
        }
    }
}






//light.enabled = !light.enabled;