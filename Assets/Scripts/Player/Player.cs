using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatformShoot
{
    public class Player : MonoBehaviour
    {
        private Rigidbody2D mRig;
        private float mGroundMoveSpeed = 5f;
        private float mJumpForce = 12f;
        private int mMaxHealth = 10;
        //public bool controlEnabled = true;

        bool jump = false;

        private void Start()
        {
            mRig = GetComponent<Rigidbody2D>();
        }
        private void FixedUpdate()
        {
            //if (controlEnabled)
            //{
            //    Console.Out.WriteLine("可以操作");
            //}
            if (Input.GetKeyDown(KeyCode.Space))
            {
                mRig.velocity = new Vector2(mRig.velocity.x, mJumpForce);
            }
            mRig.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * mGroundMoveSpeed, mRig.velocity.y);
        }
    }
}

