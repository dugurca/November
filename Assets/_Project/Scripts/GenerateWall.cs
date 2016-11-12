using UnityEngine;
using System.Collections;

public class GenerateWall : MonoBehaviour
{
    public GameObject Brick;

    void Generate(int numRows, int numCols)
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

	// Use this for initialization
	void Start () {
	    Generate(20, 40);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
