using UnityEngine;

public class Actions : MonoBehaviour {

	#region Variables
	public GameObject laser;
	public PlayerInfo MARKI;
	private float cooldown;
	private float abilityCooldown;
	private float abilityDuration;
	private AudioSource laserSND;
	private float cooldown_cp;
	private float abilityCooldown_cp;
	private bool laserVault;
	private float abilityDuration_cp;
	#endregion

	#region Unity Methods

	void Start () {
		cooldown = MARKI.cooldown;
		abilityCooldown = MARKI.abilityCooldown;
		abilityDuration = MARKI.abilityDuration;
		laserSND = gameObject.GetComponent<AudioSource>();
		cooldown_cp = MARKI.cooldown;
		abilityCooldown_cp = MARKI.abilityCooldown;
		abilityDuration_cp = MARKI.abilityDuration;

	}
    
    void Update () {
		cooldown = laserVault ? cooldown/2 : cooldown;
		cooldown -= Time.deltaTime;
		
		abilityDuration -= Time.deltaTime;

		if(abilityDuration < 0)
		{
			abilityCooldown -= Time.deltaTime;
			laserVault = false;
		}


		if (Input.GetKeyDown(KeyCode.Space) && cooldown < 0)
		{
			Instantiate(laser, transform.position, Quaternion.identity);
			cooldown = cooldown_cp;
			laserSND.Play();
		}

		if(Input.GetKeyDown(KeyCode.Q) && abilityCooldown < 0)
		{
			abilityDuration = abilityDuration_cp;
			laserVault = true;
			abilityCooldown = abilityCooldown_cp;
		}
    }

    #endregion
}
