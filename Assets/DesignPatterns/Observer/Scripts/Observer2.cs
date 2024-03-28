using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Observer2 : Observer
{
    public override void OnNotify()
    {
        Debug.Log("[옵저버 2] 실행 완료");
    }
}

