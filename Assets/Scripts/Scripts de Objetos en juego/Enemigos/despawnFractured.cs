using UnityEngine;

[DisallowMultipleComponent]
public class despawnFractured : MonoBehaviour {

    #region Variables
	[SerializeField]
	private float _tiempoDespawn;
	[SerializeField]
	private AudioSource explosionSND;
	#endregion

	#region Unity Methods

	void Start () {
		explosionSND.Play();
    }
    
    void Update () {
		_tiempoDespawn -= Time.deltaTime;
        if(_tiempoDespawn < 0)
		{
			Destroy(gameObject);
		}
    }

    #endregion
}
