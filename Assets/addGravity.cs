using UnityEngine;

public class addGravity : MonoBehaviour {

	#region Variables
	[SerializeField]
	[Range(0.1f,2f)]
	private float mass;
    #endregion

    #region Unity Methods

    void Start () {
		mass = 1f;
		gameObject.AddComponent<Rigidbody>();
		gameObject.GetComponent<Rigidbody>().mass = mass;
    }

	void Update()
	{
		int x = (int) Random.RandomRange(0, 3);
		if (x == 0)
			gameObject.GetComponent<Rigidbody>().AddForce(Vector3.left * 2);
		else if(x == 1)
			gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * 2);
		else if (x == 2)
			gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * 2);
		else
			gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * 2);

	}

    #endregion
}
