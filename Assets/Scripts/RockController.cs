using UnityEngine;
using System.Collections;

public class RockController : MonoBehaviour {

	private Rigidbody rb;
	public int StartSpeed;
	private int Speed;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody>();
		Vector3 v = new Vector3(1,1,0);
		v = Vector3.Normalize (v);
		rb.AddForce (v*StartSpeed);
		Speed = Mathf.Abs (StartSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = Speed * Vector3.Normalize (rb.velocity);
	}
}
