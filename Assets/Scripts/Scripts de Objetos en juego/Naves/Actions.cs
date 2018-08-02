using UnityEngine;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class Actions : MonoBehaviour {

	#region Variables
	[SerializeField]
	private GameObject laser;
	private Scrollbar indicador;
	[SerializeField]
	private PlayerInfo naveInfo;
	private float __cooldownDeDisparo;
	private float __cooldownDeHabilidad;
	private float __duracionHabilidad;
	private AudioSource laserSND;
	private float __cooldownDeDisparo_cp;
	private float __cooldownDeAbilidad_cp;
	private bool __laserVault; //Dice si abilidad está activada
	private float __duracionHabilidad_cp;

	[SerializeField]
	private KeyCode dispararLaser;
	[SerializeField]
	private KeyCode habilidad;
	#endregion

	#region Unity Methods

	void Start () {
		indicador = FindObjectOfType<Scrollbar>();
		__cooldownDeDisparo = naveInfo.cooldown;
		__cooldownDeHabilidad = naveInfo.cooldownHabilidad;
		__duracionHabilidad = naveInfo.duracionHabilidad;
		laserSND = gameObject.GetComponent<AudioSource>();
		__cooldownDeDisparo_cp = naveInfo.cooldown;
		__cooldownDeAbilidad_cp = naveInfo.cooldownHabilidad;
		__duracionHabilidad_cp = naveInfo.duracionHabilidad;
	}
    
    void Update () {
		calcularCooldowns();
		if (usarHabilidad() && !cooldownActivoHabilidad())
		{
			indicadorReseteo();
			activarHabilidad();
		}
        if (disparar() && !cooldownActivoDisparar())
        {
            crearLaser();
		}
    }
	#endregion

	void indicadorReseteo()
	{
		indicador.GetComponent<Scrollbar>().value = 0;
	}

	void activarHabilidad()
	{
		__duracionHabilidad = __duracionHabilidad_cp;
		__laserVault = true;
		__cooldownDeHabilidad = __cooldownDeAbilidad_cp;
	}

	void crearLaser()
	{
		//Ademas de crearlo activa el cooldown de disparar
		Instantiate(laser, transform.position, Quaternion.identity);
		__cooldownDeDisparo = __cooldownDeDisparo_cp;
		laserSND.Play();
	}

	bool disparar()
	{
		return Input.GetKeyDown(dispararLaser);
	}

	void calcularCooldowns()
	{
		__cooldownDeDisparo = calcularCooldownDisparo();
		__cooldownDeDisparo -= Time.deltaTime;
		__duracionHabilidad -= Time.deltaTime;
		if (habilidadTermino())
		{
			__cooldownDeHabilidad -= Time.deltaTime;
			subirIndicador();
			__laserVault = false;
		}
	}

	void subirIndicador()
	{
		indicador.GetComponent<Scrollbar>().value = __cooldownDeHabilidad/20f;
	}

	float calcularCooldownDisparo()
	{
		return __laserVault ? __cooldownDeDisparo / 2 : __cooldownDeDisparo;
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

	bool usarHabilidad()
	{
		return Input.GetKeyDown(habilidad);
	}
}
