using UnityEngine;
using UnityEngine.UI;
[DisallowMultipleComponent]
public class EnemyHealth : MonoBehaviour
{

    #region Variables
    [SerializeField]
    private EnemigoInfo naveInfo;
    private int _vida;
    private float[] _colores;
    #endregion

    #region Unity Methods

    void Start()
    {
        _vida = naveInfo.vida;
    }

    void OnTriggerEnter(Collider obj)
    {
        if (tocaPlaneta(obj))
        {
            bajarVida();
        }
        if (tocaLaser(obj))
        {
            bajarVida();
        }

        muerto();
    }

    #endregion

    void muerto()
    {
        if (_vida == 0)
        {
            Destroy(gameObject);
        }
    }

    bool tocaPlaneta(Collider obj)
    {
        return obj.tag == "planet";
    }
    bool tocaLaser(Collider obj)
    {
        return obj.tag == "laser";
    }

    void bajarVida()
    {
        _vida -= 1;
    }
}

