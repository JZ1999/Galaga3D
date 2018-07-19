using UnityEngine;

public class despawnFractured : MonoBehaviour {

    #region Variables
	[SerializeField]
	private float __tiempoDespawn;
	[SerializeField]
	private AudioSource explosionSND;
	#endregion

	#region Unity Methods

	void Start () {
		explosionSND.Play();
    }
    
    void Update () {
		__tiempoDespawn -= Time.deltaTime;
        if(__tiempoDespawn < 0)
		{
			Destroy(gameObject);
		}
    }

    #endregion
}
