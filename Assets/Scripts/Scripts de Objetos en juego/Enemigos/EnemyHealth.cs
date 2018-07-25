using UnityEngine;

[DisallowMultipleComponent]
public class EnemyHealth : MonoBehaviour
{

    #region Variables
    [SerializeField]
    private EnemigoInfo naveInfo;
	[SerializeField]
	private AudioSource golpeSND;
	private int _vida;
    private float[] _colores;

	[SerializeField]
	private string _tagDelPlaneta;
	[SerializeField]
	private string _tagDelLaser;
	#endregion

	#region Unity Methods

	void Start()
    {
        _vida = naveInfo.vida;
    }

    void OnTriggerEnter(Collider obj)
    {
        if (tocaPlaneta(obj) || tocaLaser(obj))
        {
			tocarSonido();
            bajarVida();
        }

		if (_vida == 0)
			muerto();
    }

    #endregion

	void tocarSonido()
	{
		golpeSND.Play();
	}

    void muerto()
    {
		Destroy(gameObject, 0.2f);
    }

    bool tocaPlaneta(Collider obj)
    {
        return obj.tag == _tagDelPlaneta;
    }
    bool tocaLaser(Collider obj)
    {
        return obj.tag == _tagDelLaser;
    }

    void bajarVida()
    {
        _vida -= 1;
    }
}

