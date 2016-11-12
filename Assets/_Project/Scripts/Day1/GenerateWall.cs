using UnityEngine;

namespace Assets._Project.Scripts.Day1
{
    public class GenerateWall : MonoBehaviour
    {
        public GameObject Brick;

        void Generate2D(int numRows, int numCols)
        {
            for (int row = 0; row < numRows; row++)
            {
                Vector3 bulge = row % 2 == 0 ? Vector3.left : Vector3.zero;
                for (int col = 0; col < numCols; col++)
                {
                    Vector3 pos = new Vector3(col * 3, row, 0) + bulge;
                    Instantiate(Brick, pos, Quaternion.identity);
                }
            }
        }

        void Generate3D(int numRows, int numCols, int numLayers)
        {
            for (int layer = 0; layer < numLayers; layer++)
            {
                for (int row = 0; row < numRows; row++)
                {
                    Vector3 bulge = row % 2 == 0 ? Vector3.left : Vector3.zero;
                    for (int col = 0; col < numCols; col++)
                    {
                        Vector3 pos = new Vector3(col * 3, row, layer * 3) + bulge;
                        Instantiate(Brick, pos, Quaternion.identity);
                    }
                }
            }
        }
    
        void Start () {
            //Generate2D(20, 40);
            Generate3D(20, 25, 4);
        }
	
        void Update () {
	
        }
    }
}
