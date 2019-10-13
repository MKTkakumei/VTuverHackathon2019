using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabTest : MonoBehaviour
{

    public float max_x;
    public float min_x;
    public float max_y;
    public float min_y;
    public float max_z;
    public float min_z;
    public float cubes_num; 


    // Use this for initialization
    void Start()
    {
        // CubeプレハブをGameObject型で取得
        GameObject obj = (GameObject)Resources.Load("Cubes");
        // Cubeプレハブを元に、インスタンスを生成、
        for (int i = 0; i < cubes_num; ++i)
        {
            float x = Random.Range(max_x, min_x);
            float y = Random.Range(max_y, min_y);
            float z = Random.Range(max_z, min_z);
            Vector3 axis = new Vector3(Random.Range(1, 0), Random.Range(1, 0), Random.Range(1, 0)); // 回転軸
            float angle = Random.Range(180, 0); // 回転の角度
            Quaternion q = Quaternion.AngleAxis(angle, axis);
            Instantiate(obj, new Vector3(x, y, z), q);
        }
    }


    void Update()
    {

    }
}