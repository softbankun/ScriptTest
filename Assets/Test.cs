using UnityEngine;
using System.Collections;

public class Boss
{
    public int hp = 100;   // 体力
    public int power = 25; // 攻撃力
    public int mp = 53; // 魔力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
    }

    // 魔法攻撃の関数
    public void Magic(int mppower)
    {
        // 残りmpを減らす
        
        if (this.mp >= mppower)
        {
            this.mp = this.mp - mppower;
            Debug.Log("MPを" + mppower + "つかって魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour
{
    void Start()
    {
        
        //int型の配列arrayを宣言して好きな値で初期化
        int[] array = { 10, 20, 30, 40, 50 };

        //配列の各要素の値を順番に表示
        Debug.Log("カウントアップ");
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        //配列の各要素の値を逆順に表示
        Debug.Log("カウントダウン");
        for (int i = 4; i > -1; i--)
        {
            Debug.Log(array[i]);
        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        // 魔法攻撃用の関数を呼び出す
        lastboss.Magic(5);
        for (int i = 0; i < 10; i++)
        {
            lastboss.Magic(5);
        }
    }

    void Update()
    {
    }

}