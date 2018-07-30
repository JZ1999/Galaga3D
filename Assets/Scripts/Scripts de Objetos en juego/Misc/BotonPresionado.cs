using UnityEngine;

[DisallowMultipleComponent]
public class BotonPresionado : MonoBehaviour {

	#region Variables
	[SerializeField]
	private AudioSource clickSND;
    #endregion

    #region Metodos de Unity
    
    #endregion

	public void click()
	{
		clickSND.Play();
	}
}
