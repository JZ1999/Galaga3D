using UnityEngine;

//TODO:
//Mover de camara 2D a 3D mediante una animación
[DisallowMultipleComponent]
public class Camara3D : MonoBehaviour {

	#region Variables
	
	private Transform jugadorTR;
	[SerializeField]
	private float _velocidadCamara = 0.25f;
	[SerializeField]
	private Vector3 offset;
	#endregion

	#region Unity Methods

	void Start () {
		//jugadorTR = GameObject.FindGameObjectWithTag("Player").transform;
	}

	private void LateUpdate()
	{
		if (!Informacion.muerto)
		{
			jugadorTR = GameObject.FindGameObjectWithTag("Player").transform;
		}
		else
		{
			jugadorTR = null;
		}
		
	}

	void FixedUpdate () {
		//Este codigo hace un efecto natural de la camara
		//Siguiendo al jugador
		if (jugadorTR != null)
		{
			Vector3 posicionDeseada = jugadorTR.position + offset;
			Vector3 posicionDeseadaMejorada = Vector3.Lerp(transform.position, posicionDeseada, _velocidadCamara);
			transform.position = posicionDeseadaMejorada;
		}
    }

    #endregion
}
