using UnityEngine;
[DisallowMultipleComponent]
public class GenerateEnemy : MonoBehaviour
{

    #region Variables
	[SerializeField]
    private float _tiempoInicial;//Tiempo inicial por cada spawn
                                //ya despues se randomiza según el spawn inicial
    public GameObject[] enemies;
    private float _tiempoInicial_cp;
    #endregion

    #region Unity Methods

    void Start()
    {
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
		int _tamanno = enemies.Length;
		for (int i = 0; i < _tamanno; i++)
		{
			float _rand = Random.Range(-5.3f, 5.3f);
			Vector3 posicionAleatoria = new Vector3(_rand, 6.3f, 0);
			Vector3 direccionDeseada = new Vector3(75, 0, 180);//Este vector va posicionar el enemigo de forma que esté viendo
															   //hacia abajo
			Instantiate(enemies[i], posicionAleatoria, Quaternion.Euler(direccionDeseada));
			_tiempoInicial = _tiempoInicial_cp + Random.Range(-_tiempoInicial_cp + 1, 2 * _tiempoInicial_cp);//Puede ser modificado
		}
    }
}