using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_0: Enemy {
    // Points enemy is worth
    protected override void Awake() {
        base.Awake();
        score = 100;
    }
}