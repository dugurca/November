using UnityEngine;
using System.Collections;

public class Checkers : MonoBehaviour
{
    public GameObject BlackCube;
    public GameObject WhiteCube;

    void CreateCheckersBoard()
    {
        for (int row = 0; row < 50; row++)
        {
            for (int col = 0; col < 50; col++)
            {
                GameObject cube;
                if ((row + col)%2 == 0) cube = Instantiate(BlackCube);
                else cube = Instantiate(WhiteCube);
                cube.transform.position = new Vector3(col, row, 0) + Vector3.up / 2f;
            }
        }
    }
    
	void Start () {
	    CreateCheckersBoard();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
