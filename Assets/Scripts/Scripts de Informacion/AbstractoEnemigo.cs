using System;
using System.Collections;
using UnityEngine;

//TODO:
//La habilidad de volverse invisible no sirve

//Para las acciones del enemigos
public abstract class AbstractoEnemigo : MonoBehaviour {

    #region Variables

    #endregion

	//Devuelve true solo si entró a alguno de los if
	protected bool usarHabilidad(EnemigoInfo.habilidades habilidad, GameObject self)
	{
		if(habilidad == EnemigoInfo.habilidades.INVISIBILIDAD)
		{
			StartCoroutine("Fade", self);
			Debug.Log(self.GetComponentInChildren<MeshRenderer>().material.color);
			return true;
		}
		return false;
	}

	IEnumerator Fade(GameObject self)
	{
		for (float f = 1f; f >= 0; f -= 0.1f)
		{
			
			Color c = self.GetComponentInChildren<MeshRenderer>().material.color;
			c.a = f;
			self.GetComponentInChildren<MeshRenderer>().material.color = c;
			yield return null;
		}
	}


}
