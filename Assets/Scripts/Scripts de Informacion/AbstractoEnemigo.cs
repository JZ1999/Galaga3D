using System.Threading;
using UnityEngine;

//TODO:
//La habilidad de volverse invisible no sirve

//Para las acciones del enemigos
public abstract class AbstractoEnemigo : MonoBehaviour {

	#region Variables
	private bool _esInvisible;
	static private bool _convertirVisible = false;
    #endregion

	//Devuelve true solo si entró a alguno de los if
	protected bool usarHabilidad(EnemigoInfo.habilidades habilidad, GameObject self)
	{
		#region Visible
		if(habilidad == EnemigoInfo.habilidades.VISIBLE)
		{
			Color c = self.GetComponentInChildren<MeshRenderer>().material.color;
			c.a = 1f;
			self.GetComponentInChildren<MeshRenderer>().material.color = c;
		}
		#endregion
		#region Invisible
		else if (habilidad == EnemigoInfo.habilidades.INVISIBLE)
		{
			Color c = self.GetComponentInChildren<MeshRenderer>().material.color;
			c.a = 0f;
			self.GetComponentInChildren<MeshRenderer>().material.color = c;
		}
		#endregion
		#region Invisibilidad
		else if (habilidad == EnemigoInfo.habilidades.INVISIBILIDAD)
		{
			float alpha = self.GetComponentInChildren<MeshRenderer>().material.color.a;
			_esInvisible = (alpha <= 0.01) ? true : false;
			if (_esInvisible || _convertirVisible)
			{
				visible(self);
				_convertirVisible = true;
				if (alpha >= 1f)
					_convertirVisible = false;
			}
			else if(!_convertirVisible)
			{
				invisible(self);
			}

			return true;
		}
		#endregion
		return false;
	}

	void invisible(GameObject self)
	{
		Color c = self.GetComponentInChildren<MeshRenderer>().material.color;
		//Se hace este if por problemas con unity
		c.a -= 0.15f;
		self.GetComponentInChildren<MeshRenderer>().material.color = c;
	}

	int visible(GameObject self)
	{
		Color c = self.GetComponentInChildren<MeshRenderer>().material.color;
		c.a += 0.13f;
		self.GetComponentInChildren<MeshRenderer>().material.color = c;
		return 1;
	}

}
