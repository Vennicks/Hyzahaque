using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDoor
{
    BoxCollider2D TriggerTP { get; set; }
    BoxCollider2D Locker { get; set; }

    void Unlock();
}
