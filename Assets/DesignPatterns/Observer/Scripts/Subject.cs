using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Subject
    //��� , ��ü�� �ǹ��ϴ� �������̽�
    //�������� ���� ������ Ȱ�� ���õ� �ڵ���� ������ �ֽ��ϴ�.
{
    void Subscribe(Observer observer);
    void UnSubscribe(Observer observer);
    void Notify();

}