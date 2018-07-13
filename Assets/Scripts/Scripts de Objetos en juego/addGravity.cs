using UnityEngine;

//Le agrega rigidbody a cada fracturacion del planeta
public class addGravity : MonoBehaviour {

	#region Variables
	[SerializeField]
	[Range(0.1f,2f)]
	private float mass;
	int m;
    #endregion

    #region Unity Methods

    void Start () {
		mass = 1f;
		m = 1;
		gameObject.AddComponent<Rigidbody>();
		gameObject.GetComponent<Rigidbody>().mass = mass;
    }

	void Update()
	{
		int x = (int) Random.Range(0, 4);
		if (m == 1)
		{
			m--;
			Debug.Log(x);
		}
		if (x == 0)
			gameObject.GetComponent<Rigidbody>().AddForce(Vector3.left * 4);
		else if(x == 1)
			gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * 4);
		else if (x == 2)
			gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * 3);
		else
			gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * 3);

	}

    #endregion
}
