using UnityEngine;
[DisallowMultipleComponent]
public class PlanetMovement : MonoBehaviour {

	#region Variables
	private GameObject obj;
	public float _velocidadMovimiento;
	public float _velocidadRotacion;
	#endregion

	#region Unity Methods

	void Start () {
		obj = gameObject;
    }

	void Update()
	{
		obj.transform.Rotate(new Vector3(0, _velocidadRotacion * Time.deltaTime,0));
		obj.transform.Translate(new Vector3(0, -_velocidadMovimiento * Time.deltaTime));
	}

	#endregion
}
