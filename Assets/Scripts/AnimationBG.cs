using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBG : MonoBehaviour
{
    Material material;
    Vector2 movement;
    public Vector2 speed;       // public 之后，该参数就能在Unity中可见

    // Start is called before the first frame update
    void Start()
    {
        // 传入的类是Renderer是因为我们的脚本是放在Mesh Renderer的。然后我们需要获取Mesh Renderer中的 .material
        material = GetComponent<Renderer>().material;    // 这样就拿到了刚刚的材质
    }

    // Update is called once per frame
    void Update()
    {
        speed.y = -1f;
        movement += speed * Time.deltaTime;     // Time.deltaTime是 0.02s。这里我们设置一个偏移量大小
        material.mainTextureOffset = movement;  // 我们通过movement来控制背景材质的 偏移量。
    }
}
