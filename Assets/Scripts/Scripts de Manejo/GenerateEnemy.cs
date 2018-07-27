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
        _tiempoInicial -= Time.deltaTime;
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
			if (posibilidadDeSpawnear())
			{
				Vector3 posicion = calcularPosicionDeSpawn();
				Vector3 direccionDeseada = new Vector3(75, 0, 180);//Este vector va posicionar el enemigo de forma que esté viendo
																   //hacia abajo
				Instantiate(enemigos[i], posicion, Quaternion.Euler(direccionDeseada));
				_tiempoInicial = _tiempoInicial_cp + Random.Range(-_tiempoInicial_cp + 1, 2 * _tiempoInicial_cp)+3;//Puede ser modificado
			}
		}
    }

	bool posibilidadDeSpawnear()
	{
		return Random.Range(0, 2) == 1;
	}
	Vector3 calcularPosicionDeSpawn()
	{
		float _randX = Random.Range(-6.5f, 6.5f);
		float _randY = Random.Range(4, 6.5f);
		Vector3 posicionAleatoria = new Vector3(_randX, _randY, 0);
		float _offsetY = 6.3f;//puede ser modificado
		Vector3 offset = new Vector3(0, _offsetY+ posicionJugadorTR.position.y, 0);
		Vector3 posicionDeseada = posicionAleatoria + offset;
		return posicionDeseada;
	}
}