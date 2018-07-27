﻿using UnityEngine;
[DisallowMultipleComponent]
public class GeneratePlanets : MonoBehaviour {

	#region Variables
	[SerializeField]
	private string _tagDelJugador;
	[SerializeField] float _tiempoInicial;//Tiempo inicial por cada spawn
										  //ya despues se randomiza según el spawn inicial
	[SerializeField] GameObject planet;
	private float _tiempoInicial_cp;
	private Transform posicionJugadorTR;
	#endregion

	#region Unity Methods

	void Start () {
		posicionJugadorTR = GameObject.FindGameObjectWithTag(_tagDelJugador).transform;
		_tiempoInicial_cp = _tiempoInicial;
    }
    
    void Update () {
		_tiempoInicial -= 1 * Time.deltaTime;
		if(_tiempoInicial < 0)
		{
			spawnearPlaneta(calcularVector());
		}
    }
    #endregion

	Vector3 calcularVector()
	{
		float _randX = Random.Range(-5.5f, 5.5f);
		float _randY = Random.Range(6, 8.5f);
		Vector3 posicionAleatoria = new Vector3(_randX, _randY, 0);
		float _offsetY = 7f;//puede ser modificado
		Vector3 offset = new Vector3(0,_offsetY+posicionJugadorTR.position.y,0);
		Vector3 posicionDeseada = posicionAleatoria + offset;
		return posicionDeseada;
	}

	void spawnearPlaneta(Vector3 posicion)
	{
		Instantiate(planet, posicion, Quaternion.identity);
		_tiempoInicial = _tiempoInicial_cp + Random.Range(-_tiempoInicial_cp + 1, 2 * _tiempoInicial_cp);//Puede ser modificado
	}
}
