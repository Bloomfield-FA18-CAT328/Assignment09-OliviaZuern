using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {
    public int targetPnt;
    private PathScript path;


	// Use this for initialization
	void Start () {
        path = GameObject.FindGameObjectWithTag("GameController").GetComponent<PathScript>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, path.Points[targetPnt], Time.deltaTime*2f);

    if( Vector3.Distance(transform.position,path.Points[targetPnt]) <= 0.1f){
            targetPnt += 1;
            if(targetPnt > path.Points.Count-1) {
                targetPnt = 0;
            }
        }
	}


}
