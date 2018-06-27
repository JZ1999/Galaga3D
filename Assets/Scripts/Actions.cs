using UnityEngine;

public class Actions : MonoBehaviour {

	#region Variables
	public GameObject laser;
	public float cooldown;
	private float aux;
    #endregion

    #region Unity Methods

    void Start () {
		aux = cooldown;
    }
    
    void Update () {
		cooldown -= Time.deltaTime;
		if (Input.GetKeyDown(KeyCode.Space) && cooldown < 0)
		{
			Instantiate(laser, transform.position, Quaternion.identity);
			cooldown = aux;
		}
    }

    #endregion
}
