using UnityEngine;
using System.Collections;

public class Tiling : MonoBehaviour {

    public Transform[] spawnables;
	public Transform[] upperLevel;
    public float movedX;
	public float fixY;
	public float offCamera;

	// Use this for initialization
	void Start () {
		//näihin molempiin on varmaa parempi ratkaisu
		fixY = 7f; //en saanu muuten paikalleen
		offCamera = 15f; //spawnaa ulompana

		Instantiate(spawnables[Random.Range(0, 1)], new Vector3(transform.position.x+1, transform.position.y-fixY, 0-5), Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x / movedX > 15)
        {
			int r = Random.Range (0, 3);

			if (r == 0) {
				//Debug.Log("Spawn up");
				Instantiate(upperLevel[Random.Range(0, 8)], new Vector3(transform.position.x+offCamera, transform.position.y-(fixY+2), 0-5), Quaternion.identity);

			} else {
				//Debug.Log("Spawn down");
				Instantiate(spawnables[Random.Range(0, 12)], new Vector3(transform.position.x+offCamera, transform.position.y-fixY, 0-5), Quaternion.identity);

			}
			movedX++;
			offCamera += 3;

        }

	
	}
}
