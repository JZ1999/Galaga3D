using UnityEngine;

public class PlanetMovement : MonoBehaviour {

	#region Variables
	private GameObject obj;
	public float speed;
	#endregion

	#region Unity Methods

	void Start () {
		obj = gameObject;
    }

	void Update()
	{
		obj.transform.Rotate(new Vector3(0, speed * Time.deltaTime,0));
		obj.transform.Translate(new Vector3(0, -speed * Time.deltaTime));
	}

	#endregion
}
