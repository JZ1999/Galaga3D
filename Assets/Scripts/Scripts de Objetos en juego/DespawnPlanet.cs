using UnityEngine;

public class DespawnPlanet : MonoBehaviour {

    #region Variables
	private float __tiempoDeVida = 40f;
    #endregion

    #region Unity Methods

    void Start () {
        
    }
    
    void Update () {
		__tiempoDeVida -= Time.deltaTime;
		if (__tiempoDeVida < 0)
		{
			Destroy(gameObject);
		}
    }

    #endregion
}
