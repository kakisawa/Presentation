using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int HP = 3;    // EnemyのHP

    // Playerの弾に当たったときの処理
    public void Damage(int bulletDamage)
    {
        HP -= bulletDamage;   // HPを1減らす
        
        if(HP <= 0)
        {
            Destroy(gameObject);    // 敵が消える
        }
    }
}
