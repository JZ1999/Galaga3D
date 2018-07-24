using UnityEngine;

//TODO:
//-remover variable _x y reemplazarla
[DisallowMultipleComponent]
public class actvarCamaras : MonoBehaviour {

	#region Variables
	[SerializeField]
	private GameObject[] camaras;
	[SerializeField]
	private float _tiempo;
	bool _x = true;//Variable temporal
	#endregion

	#region Unity Methods
    
	void Awake()
	{
		camaras[0].GetComponent<Camera>().enabled = true;
		camaras[1].GetComponent<Camera>().enabled = false;
	}

    void Update () {
		_tiempo -= Time.deltaTime;
		if (_tiempo < 0 && _x)
		{
			activarOtraCamara();
		}
	}

    #endregion

	void activarOtraCamara()
	{

		_x = false;
		camaras[1].GetComponent<Camera>().enabled = true;
		camaras[0].GetComponent<Camera>().enabled = false;
	}
}
