﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;
    public void Magic()
    {
        if (mp >= 5)
        {
            mp -= 5;
            // mpが5以上だった場合
            Debug.Log("魔法攻撃をした。のこりMPは" + mp + "。");
        }
        else
        {
            // mpが5未満だった場合
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }
}
public class Test : MonoBehaviour
{
    private int i;
    // Use this for initialization
    void Start()
    {
        // 要素数5の配列を初期化する
        int[] array = new int[5];

        // 配列の各要素に値を代入する
        array[0] = 78;
        array[1] = 39;
        array[2] = 21;
        array[3] = 60;
        array[4] = 3;

        // 配列の要素をすべて表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        // 配列の要素を逆順に表示する
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);

        }

        Boss lastboss = new Boss();
        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic();
        }

    }
    // Update is called once per frame
    void Update()
    {
    }
}