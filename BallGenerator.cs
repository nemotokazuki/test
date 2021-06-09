using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    public GameObject ballPrefab;

    private float limitTime = 2.0f;
    private float elapsedTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime; // 経過時間を計算（差分時間を追加）

        if (elapsedTime >= limitTime) // 経過時間が制限時間を超過したら
        {
            elapsedTime = 0.0f; // 経過時間をゼロクリア

            GameObject obj = Instantiate(ballPrefab);
            obj.transform.position = new Vector3(0, 1.7f, -3);

            float dx = Random.Range(-1.0f, 1.0f);
            float dy = Random.Range(-1.5f, 0.8f);
            //Debug.Log("dx = " + dx + " , " + dy);

            obj.GetComponent<Rigidbody>().AddForce(0 + dx, 0.1f + dy, -24);
            obj.GetComponent<Rigidbody>().angularVelocity = new Vector3(dx*100, dy*100, 0);
        }
    }
}
