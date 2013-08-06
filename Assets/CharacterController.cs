using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {
	public float walkStrength;
	public Vector3 jampVelocity;
	
	private Material _mat;
	private Vector2 _mainTexScale;

	// Use this for initialization
	void Start () {
		_mat = renderer.material;
		_mainTexScale = _mat.mainTextureScale;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey(KeyCode.D)) {
			rigidbody.AddForce(walkStrength * Vector3.right);
			_mat.mainTextureScale = _mainTexScale;
		}
		if (Input.GetKey(KeyCode.A)) {
			rigidbody.AddForce(-walkStrength * Vector3.right);
			_mat.mainTextureScale = new Vector2(-1f * _mainTexScale.x, _mainTexScale.y);
		}
		if (Input.GetKeyDown(KeyCode.Space)) {
			rigidbody.velocity += jampVelocity;
		}
	}
}
