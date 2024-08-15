using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/********************************************************************************************
Copyright (c) 0- Yinghai

这个代码就是控制 Fan Platform，也就是淡蓝色的小平台。
我们只希望在 Fan Platform 被碰撞了之后，再产生一些动画或者播放一些动画。

所以这就类似于一个事件触发器。所以我们不能使用 Update()，而是需要用到 OnCollisionEnter2D() 方法

********************************************************************************************/
public class NewBehaviourScript : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    /// 'other' 参数就是 与当前 对象Fan Platform 发生碰撞的 对象
    /// 所以我们想象一下游戏场景，other就是我们的玩家
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player")) {
            animator.Play("Fan_Run");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
