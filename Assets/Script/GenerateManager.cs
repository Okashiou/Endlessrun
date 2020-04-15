using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateManager : MonoBehaviour
{
    //アイテムプレファブを格納するへんすう
    public GameObject itemPrefab;

    //プレイヤートランスフォームコンポーネントを格納する変数
    public Transform playerTransform;

    //生成する感覚
    public float generateInterval;

    //生成する時間
    public float generateSpeed;


    // Start is called before the first frame update
    void Start()
    {
        Generate();
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void Generate()
    {
        //生成する位置
        Vector3 generatePosition = new Vector3(0, itemPrefab.transform.position.y, playerTransform.position.z + generateInterval);

        
        //アイテムを作成
        Instantiate(itemPrefab, generatePosition, Quaternion.identity);

        //何度もよばれる
        Invoke("Generate", generateSpeed);

    }

}
