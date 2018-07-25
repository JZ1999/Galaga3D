using UnityEngine;
[DisallowMultipleComponent]
public class GenerateEnemy : MonoBehaviour
{
	#region Variables
	[SerializeField]
	private string _tagDelJugador;
	[SerializeField]
    private float _tiempoInicial;//Tiempo inicial por cada spawn
    [SerializeField]                            //ya despues se randomiza según el spawn inicial
    private GameObject[] enemigos;
	private Transform posicionJugadorTR;
	private float _tiempoInicial_cp;
    #endregion

    #region Unity Methods

    void Start()
    {
		posicionJugadorTR = GameObject.FindGameObjectWithTag(_tagDelJugador).transform;
        _tiempoInicial_cp = _tiempoInicial;
    }

    void Update()
    {
        _tiempoInicial -= 1 * Time.deltaTime;
        if (_tiempoInicial < 0)
        {
            spawnearEnemigo();
        }
    }
    #endregion

    void spawnearEnemigo()
    {
		int _tamanno = enemigos.Length;
		for (int i = 0; i < _tamanno; i++)//For temporal para spawnear todos los enemigos
											//del arreglo enemigos
		{
			Vector3 posicion = calcularPosicionDeSpawn();
			Vector3 direccionDeseada = new Vector3(75, 0, 180);//Este vector va posicionar el enemigo de forma que esté viendo
															   //hacia abajo
			Instantiate(enemigos[i], posicion, Quaternion.Euler(direccionDeseada));
			_tiempoInicial = _tiempoInicial_cp + Random.Range(-_tiempoInicial_cp + 1, 2 * _tiempoInicial_cp);//Puede ser modificado
		}
    }

	Vector3 calcularPosicionDeSpawn()
	{
		float _rand = Random.Range(-5.3f, 5.3f);
		Vector3 posicionAleatoria = new Vector3(_rand, 0, 0);
		float _offsetY = 6.3f;//puede ser modificado
		Vector3 offset = new Vector3(0, _offsetY, 0);
		Vector3 posicionDeseada = posicionAleatoria + posicionJugadorTR.position + offset;
		return posicionDeseada;
	}
}