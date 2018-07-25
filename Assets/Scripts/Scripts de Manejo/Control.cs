using UnityEngine;
[DisallowMultipleComponent]
public class Control : MonoBehaviour {
	/*
		Contiene los jugadores en nivel y los inicializa 
	*/
	#region Variables
	[SerializeField]
	private GameObject[] naves;
	private GameObject nave;
	#endregion

	#region Unity Methods

	void Awake()
	{
		nave = naves[Informacion.J1];
		Quaternion rotacionVertical = Quaternion.Euler(new Vector3(270, 0, 0));
		Instantiate(nave, Vector3.zero, rotacionVertical);
		
	}
	#endregion
}
