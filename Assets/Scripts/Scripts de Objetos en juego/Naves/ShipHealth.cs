using UnityEngine;
using UnityEngine.UI;
[DisallowMultipleComponent]
public class ShipHealth : MonoBehaviour {

	#region Variables
	[SerializeField]
	private PlayerInfo naveInfo;
	[SerializeField]
	private AudioSource golpeSND;
	[HideInInspector]
	public Text vidaTXT;
	private int _vida;
	private float[] _colores;
	private float _porcentajeRojo;

	[SerializeField]
	private string _tagDelPlaneta;
	[SerializeField]
	private string _tagDelLaserEnemigo;
	#endregion

	#region Unity Methods

	void Start () {
		vidaTXT = FindObjectOfType<Text>();
		_vida = naveInfo.vida;
		vidaTXT.text = naveInfo.vida.ToString();
		_colores = new float[] { vidaTXT.color.r, vidaTXT.color.g, vidaTXT.color.b };
		_porcentajeRojo = _colores[0] / 20;
	}

	void OnTriggerEnter(Collider obj)
	{
		if (tocaPlaneta(obj) || tocaLaser(obj))
		{
			tocarSonido();
			bajarVida();
		}

		if(_vida == 0)
			muerto();
	}

    #endregion

	void tocarSonido()
	{
		golpeSND.Play();
	}

	void muerto()
	{
		Informacion.muerto = true;
		Destroy(gameObject);
	}

	bool tocaPlaneta(Collider obj)
	{
		return obj.tag == _tagDelPlaneta;
	}

    bool tocaLaser(Collider obj)
    {
        return obj.tag == _tagDelLaserEnemigo;
    }

    void bajarVida()
	{
		_vida -= 1;
		cambiarColorDeVida();
	}

	void cambiarColorDeVida()
	{
		vidaTXT.text = _vida.ToString();
		vidaTXT.color = new Color(_colores[0] -= _porcentajeRojo, _colores[1], _colores[2]);
	}
}
