using UnityEngine;

public class Actions : MonoBehaviour {

	#region Variables
	[SerializeField]
	private GameObject laser;
	[SerializeField]
	private PlayerInfo MARKI;
	private float __cooldownDeDisparo;
	private float __cooldownDeHabilidad;
	private float __duracionHabilidad;
	private AudioSource laserSND;
	private float __cooldownDeDisparo_cp;
	private float __cooldownDeAbilidad_cp;
	private bool __laserVault; //Dice si abilidad está activada
	private float __duracionHabilidad_cp;
	#endregion

	#region Unity Methods

	void Start () {
		__cooldownDeDisparo = MARKI.cooldown;
		__cooldownDeHabilidad = MARKI.abilityCooldown;
		__duracionHabilidad = MARKI.abilityDuration;
		laserSND = gameObject.GetComponent<AudioSource>();
		__cooldownDeDisparo_cp = MARKI.cooldown;
		__cooldownDeAbilidad_cp = MARKI.abilityCooldown;
		__duracionHabilidad_cp = MARKI.abilityDuration;
	}
    
    void Update () {
		calcularCooldowns();
		if (usarHabilidad() && !cooldownActivoHabilidad())
		{
			activarHabilidad();
		}
        if (disparar() && !cooldownActivoDisparar())
        {
            crearLaser();
		}
    }
	#endregion

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
		return Input.GetKeyDown(KeyCode.Space);
	}

	void calcularCooldowns()
	{
		__cooldownDeDisparo = calcularCooldownDisparo();
		__cooldownDeDisparo -= Time.deltaTime;
		__duracionHabilidad -= Time.deltaTime;
		if (habilidadTermino())
		{
			__cooldownDeHabilidad -= Time.deltaTime;
			__laserVault = false;
		}
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
		return Input.GetKeyDown(KeyCode.Q);
	}
}
