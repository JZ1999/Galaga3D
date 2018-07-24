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

	static public float tiempo;//Que tenga un tiempo dado antes de que empiece
						//a llamar la funcion conseguirJugadorTR() debido a
						//que sino causa un error de objeto null.
	#endregion

	#region Unity Methods

	private void Awake()
	{
		tiempo = 5f;
	}

	private void LateUpdate()
	{
		tiempo -= Time.deltaTime;
		Debug.Log(tiempo);
		if(tiempo <= 0)
		{
			conseguirJugadorTR();
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

	void conseguirJugadorTR()
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
}
