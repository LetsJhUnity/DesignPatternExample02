using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Observer1 : Observer
{
    public override void OnNotify()
    {
        Debug.Log("[옵저버 1] 실행 완료");
    }
}

