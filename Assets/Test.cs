using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class Boss
{

    int MP = 53;
    int useMP = 5;

    public void Magic()
    {
        while (MP > 5)
        {
            if (MP > 5)
            {
                MP -= useMP;
                Debug.Log("魔法攻撃をした。残りMPは" + MP + "。");

            }

            else
            {
                Debug.Log("MPが足りないため、魔法が使えない。");
                //break;
            }
        }
    }
}



public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int[] points = { 80, 50, 35, 60, 10 };

        // 配列の要素数のぶんだけ処理を繰り返す
        for (int i = 0; i < points.Length; i++)
        {

            // 配列の要素を表示する
            Debug.Log("順番" + points[i]);
            
        }
        for (int i = 4; i >= 0; i--)
        {

            // 配列の要素を表示する
            Debug.Log("逆順" + points[i]);

        }
        Boss lastboss = new Boss();
        lastboss.Magic();

    }
        

        // Update is called once per frame
        void Update()
        {


        }
    
}