using UnityEngine;
using System.Collections;

public class Task : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
	//要素数5の配列arrayを宣言し初期化
        int[] array = {10, 30, 20, 40, 50};
	
	//配列の要素数ぶんだけ処理を繰り返す
	for (int i = 0; i < array.Length; i++)
	{
		//arrayを表示する
		Debug.Log(array[i]);
	}	

	//配列の要素数ぶんだけ処理を繰り返す
	for (int a = array.Length - 1; a >= 0; a--)
	{
		//arrayを表示する
		Debug.Log(array[a]);
	}		
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
