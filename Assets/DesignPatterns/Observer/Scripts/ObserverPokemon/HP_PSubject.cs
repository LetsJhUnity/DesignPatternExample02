using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HP_PSubject : MonoBehaviour, PSubject
{
    private List<PObserver> m_PObservers = new List<PObserver> ();
    private float m_HP;
    private float enemy_HP;
    private float m_MaxHP;
    private float e_MaxHP;
    private void Start()
    {
        m_HP = 100;
        enemy_HP = 100;
        m_MaxHP = m_HP;
        e_MaxHP = enemy_HP;
        var MHP = GetComponent<PmHpObserver>();
        var EHP = GetComponent<PeHpObserver>();

        Register(MHP);
        Register(EHP);

        MHP.PObserverUpdate(m_HP, enemy_HP);
        EHP.PObserverUpdate(m_HP, enemy_HP);
    }

    public void Attack()
    {
        enemy_HP -= 10;
        m_PObservers[1].PObserverUpdate(m_HP, enemy_HP);
    }

    public void SetHP(float M_HP, float E_HP)
    {
        m_HP = M_HP;
        enemy_HP = E_HP;
        Notify();
    }
    public void Notify()
    {
       foreach(var pokemen in m_PObservers)
        {
            pokemen.PObserverUpdate(m_HP, enemy_HP);
        }
    }
    public void Register(PObserver observer)
    {
        m_PObservers.Add(observer);
    }
    public void Remove(PObserver observer)
    {
        m_PObservers.Remove(observer);
    }
}
