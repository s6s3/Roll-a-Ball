using UnityEngine;
using System.Collections;

public class FollowerPlayer : MonoBehaviour {
    public Transform target;
    private Vector3 offset;
    
    void Start()
    {
        offset = GetComponent<Transform>().position - target.position;
    }

	// Update is called once per frame
	void Update () {
        GetComponent<Transform>().position = target.position + offset;
	}
}
