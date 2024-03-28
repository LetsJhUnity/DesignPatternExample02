using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class PeHpObserver : MonoBehaviour, PObserver
{
    [SerializeField] private Slider e_hpBar;

    private HP_PSubject HP_PSubject = null;

    public void PObserverUpdate(float myHP, float enemyHP)
    {
        e_hpBar.value = enemyHP;
    }

    // Use this for initialization
    void Start()
    {
        HP_PSubject = GetComponent<HP_PSubject>();
    }
}
