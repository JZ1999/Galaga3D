using UnityEngine;

public class DespawnPlanet : MonoBehaviour {

    #region Variables
	private float timer = 40f;
    #endregion

    #region Unity Methods

    void Start () {
        
    }
    
    void Update () {
		timer -= Time.deltaTime;
		if (timer < 0)
		{
			Destroy(gameObject);
		}
    }

    #endregion
}
