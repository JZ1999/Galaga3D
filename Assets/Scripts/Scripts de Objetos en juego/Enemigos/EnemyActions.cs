using UnityEngine;
[DisallowMultipleComponent]
public class EnemyActions : AbstractoEnemigo
{

    #region Variables
    [SerializeField]
    private GameObject laserEnemigo;
    [SerializeField]
    private EnemigoInfo naveInfo;

	[SerializeField]
	private float _tiempo;//Usado con la nave invisible
	private float _tiempo_cp;
	private int _repeticiones = 14;//Usado con la nave invisible
	private int _repeticiones_cp;//Usado con la nave invisible
	private float _tiempoInvisible = 5f;
	private float _tiempoInvisible_cp = 5f;

	private float __cooldownDeDisparo;
    private float __cooldownDeHabilidad;
    private float __duracionHabilidad;
    private AudioSource laserSND;
    private float __cooldownDeDisparo_cp;
    private float __cooldownDeHabilidad_cp;
    private bool __habilidadActiva;
    private float __duracionHabilidad_cp;
	private EnemigoInfo.habilidades _habilidad;
    #endregion

    #region Unity Methods

    void Start()
    {
        __cooldownDeDisparo = naveInfo.cooldown;
        __cooldownDeHabilidad = naveInfo.cooldownHabilidad;
        __duracionHabilidad = naveInfo.duracionHabilidad;
        laserSND = gameObject.GetComponent<AudioSource>();
        __cooldownDeDisparo_cp = naveInfo.cooldown;
        __cooldownDeHabilidad_cp = naveInfo.cooldownHabilidad;
        __duracionHabilidad_cp = naveInfo.duracionHabilidad;
		_habilidad = naveInfo.habilidad;
		_tiempo_cp = _tiempo;
		_repeticiones_cp = _repeticiones;

    }

    void Update()
    {
		calcularCooldowns();
		if (__habilidadActiva)
		{
			if (_tiempo <= 0)
			{
				if (_repeticiones >= (_repeticiones_cp / 2) || _tiempoInvisible <= 0)
				{
					base.usarHabilidad(_habilidad, gameObject);
					_tiempo = _tiempo_cp;
					_repeticiones -= 1;
					if (_repeticiones <= 0)
					{
						_repeticiones = _repeticiones_cp;
						__habilidadActiva = false;
						_tiempoInvisible = _tiempoInvisible_cp;
						base.usarHabilidad(EnemigoInfo.habilidades.VISIBLE , gameObject);
					}
				}
				else
				{
					base.usarHabilidad(EnemigoInfo.habilidades.INVISIBLE, gameObject);
					_tiempoInvisible -=Time.deltaTime;
				}
			}
		}

        if (disparar() && !cooldownActivoDisparar())
        {
            crearLaser();
        }
		if (!cooldownActivoHabilidad())
		{
			activarHabilidad();
		}
		_tiempo -= Time.deltaTime;
	}
    #endregion

	void activarHabilidad()
    {
		if (_habilidad != EnemigoInfo.habilidades.NINGUNA)
		{
			__duracionHabilidad = __duracionHabilidad_cp;
			__cooldownDeHabilidad = __cooldownDeHabilidad_cp;
			__habilidadActiva = true;
		}
    }

    void crearLaser()
    {
        //Ademas de crearlo activa el cooldown de disparar
        Instantiate(laserEnemigo, transform.position, Quaternion.identity);
        __cooldownDeDisparo = __cooldownDeDisparo_cp*3;
        laserSND.Play();
    }

    bool disparar()
    {
        return true;
    }

    void calcularCooldowns()
    {
        __cooldownDeDisparo -= Time.deltaTime;
        __duracionHabilidad -= Time.deltaTime;
        if (habilidadTermino())
        {
            __cooldownDeHabilidad -= Time.deltaTime;
			__habilidadActiva = false;
        }
    }

    bool cooldownActivoHabilidad()
    {
        return __cooldownDeHabilidad > 0;
    }

    bool cooldownActivoDisparar()
    {
        return __cooldownDeDisparo > 0;
    }

    bool habilidadTermino()
    {
        return __duracionHabilidad < 0;
    }

}