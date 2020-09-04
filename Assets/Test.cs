using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    private int mp = 53;
    public void Magic()
    {
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");

        }
    }
    
}



public class Test : MonoBehaviour
{
    


    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        for(int i=0; i<array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = array.Length - 1; i >= 0; i--)
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
