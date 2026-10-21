using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_5: Enemy {
    [Header("Enemy_5 Inscribed Fields")]
    public float speedBoost = 2f;
    public float boostAtY = 0f;

    public override void Move() {
        Vector3 tempPos = pos;
        float currentSpeed = speed;
        if (tempPos.y < boostAtY) {
            currentSpeed *= speedBoost;
        }

        tempPos.y -= currentSpeed * Time.deltaTime;
        pos = tempPos;
    } 

    // Points enemy is worth
    protected override void Awake() {
        base.Awake();
        score = 500;
    }

}