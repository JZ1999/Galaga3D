﻿using UnityEngine;

[DisallowMultipleComponent]
public class camara2DMovimiento : MonoBehaviour {

	#region Variables
	[SerializeField]
	private string _tagDelJugador;
	private Transform jugadorTR;
	[SerializeField]
	private float _velocidadCamara = 0.25f;
	[SerializeField]
	private Vector3 offset;

	static public float tiempo;//Que tenga un tiempo dado antes de que empiece
							   //a llamar la funcion conseguirJugadorTR() debido a
							   //que sino causa un error de objeto null.
	#endregion

	#region Metodos de Unity
	void Start () {
		tiempo = 2f;
	}
    
    void Update () {
		tiempo -= Time.deltaTime;
		if (tiempo <= 0)
		{
			conseguirJugadorTR();
		}
	}

	void FixedUpdate()
	{
		//Este codigo hace un efecto natural de la camara
		//Siguiendo al jugador
		if (jugadorTR != null)
		{
			Vector3 posicionDeseada = new Vector3(0, jugadorTR.position.y,-6) + offset;
			Vector3 posicionDeseadaMejorada = Vector3.Lerp(transform.position, posicionDeseada, _velocidadCamara);
			transform.position = posicionDeseada;
		}
	}

	#endregion


	void conseguirJugadorTR()
	{
		if (!Informacion.muerto)
		{
			jugadorTR = GameObject.FindGameObjectWithTag(_tagDelJugador).transform;
		}
		else
		{
			jugadorTR = null;
		}
	}
}
