using UnityEngine;

public class Control : MonoBehaviour {

	#region Variables
	[SerializeField]
	private GameObject[] naves;
	private GameObject nave;
	#endregion

	#region Unity Methods

	void Start()
	{
		nave = naves[Informacion.J1];
		Instantiate(nave, Vector3.zero, Quaternion.Euler(new Vector3(270,0,0)));
	}

	void Update()
	{

	}

	#endregion
}
