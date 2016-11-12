using UnityEngine;
using System.Collections;

public class ShootBall : MonoBehaviour
{
    public GameObject Ball;

    void Shoot()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            GameObject ball = Instantiate(Ball);
            ball.transform.position = this.transform.position;
            Vector3 forceDir = hit.point - transform.position;
            ball.GetComponent<Rigidbody>().velocity = forceDir * 5f;
        }
    }
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetMouseButtonDown(0))
	    {
	        Shoot();
	    }
	}
}
