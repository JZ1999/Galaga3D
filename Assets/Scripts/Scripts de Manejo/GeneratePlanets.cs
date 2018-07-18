﻿using UnityEngine;

public class GeneratePlanets : MonoBehaviour {

	#region Variables
	public float initTimer;//Tiempo inicial por cada spawn
							//ya despues se randomiza según el spawn inicial
	public GameObject planet;
	private float aux;
    #endregion

    #region Unity Methods

    void Start () {
		aux = initTimer;
    }
    
    void Update () {
		initTimer -= 1 * Time.deltaTime;
		if(initTimer < 0)
		{
			
			float rand = Random.Range(-5.5f,5.5f);
			Vector3 randPos = new Vector3(rand,6.3f,0);
			
			Instantiate(planet, randPos, Quaternion.identity);
			initTimer = aux + Random.Range(-aux+1,2*aux);//Puede ser modificado
		}
    }

    #endregion
}