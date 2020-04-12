using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateGround : MonoBehaviour
{

    //地面のプレファブ
    public GameObject groundPrefab;

    // プレイヤーのトランスフォームコンポーネント

    public Transform playerTransform;

    //地面のトランスフォームコンポーネント
    public Transform groundTransform;

    //地面を管理するリスト
    public List<GameObject> groundList = new List<GameObject>();


    //更新する時間
    public float UpdateSpeed;

    // Start is called before the first frame update
    void Start()
{
        UpdateGround();
}

// Update is called once per frame
void Update()

{


}


//地面を更新するメソッド

void UpdateGround()
{
    GameObject nextGround = GenerateNextGround();

        //作った地面をリストに格納
        groundList.Add(nextGround);

        //数秒後に地面を作る
        Invoke("UpdateGround", UpdateSpeed);

        //数秒後に地面をけす
        Invoke("DestroyOldestGround", UpdateSpeed);

    }


GameObject GenerateNextGround()
        {
    //プレイヤーの位置を変数に格納
    float playerPostion = playerTransform.position.z;

        //地面の長さ
        float groundScale = groundTransform.localScale.z;


    //次の地面を作成する場所
    Vector3 nextGroundPosition = new Vector3(0, 0, playerPostion + groundScale);

    GameObject nextGround = Instantiate(groundPrefab, nextGroundPosition, Quaternion.identity);

    return nextGround;

}

    //いちばん古い地面を消すメソッド

    void DestroyOldestGround()
    {
        //一番古い地面を変数に格納
        GameObject oldsetGround = groundList[0];

        //一番古い地面を取り除く
        groundList.RemoveAt(0);

        
        //一番古い地面を消す
        Destroy(oldsetGround);


    }




}
