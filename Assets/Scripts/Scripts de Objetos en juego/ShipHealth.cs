using UnityEngine;
using UnityEngine.UI;
[DisallowMultipleComponent]
public class ShipHealth : MonoBehaviour {

	#region Variables
	[SerializeField]
	private PlayerInfo naveInfo;
	[HideInInspector]
	public Text vidaTXT;
	private int _vida;
	private float[] _colores;
	private float _porcentajeRojo;
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
		if (tocaPlaneta(obj))
		{
			bajarVida();
		}
        if (tocaLaser(obj))
        {
            bajarVida();
        }

        muerto();
	}

    #endregion

	void muerto()
	{
		if (_vida == 0)
		{
			Destroy(gameObject);
		}
	}

	bool tocaPlaneta(Collider obj)
	{
		return obj.tag == "planet";
	}
    bool tocaLaser(Collider obj)
    {
        return obj.tag == "enemylaser";
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
