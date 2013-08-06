using UnityEngine;
using System.Collections;

public class CameraMan : MonoBehaviour {
	public Transform target;
	
	private Vector3 _offset;

	// Use this for initialization
	void Start () {
		_offset = transform.position - target.position;
	}
	
	// Update is called once per frame
	void Update () {
		var pos = transform.position;
		var targetPos = target.position;
		pos.x = targetPos.x + _offset.x;
		transform.position = pos;
	}
}
