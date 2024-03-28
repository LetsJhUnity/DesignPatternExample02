using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class PmHpObserver : MonoBehaviour, PObserver
{
    [SerializeField] private Slider m_hpBar;

    private HP_PSubject HP_PSubject = null;

    public void PObserverUpdate(float myHP, float enemyHP)
    {
        m_hpBar.value = myHP;
    }

    // Use this for initialization
    void Start()
    {
        HP_PSubject = GetComponent<HP_PSubject>();
    }

}
