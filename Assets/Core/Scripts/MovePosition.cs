using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePosition : MonoBehaviour
{
    // 플레이 되었을 때 한 번만 호출
    void Start()
    {
        //Debug.Log("Start!");
        //Debug.LogWarning("이 함수는 경고를 표시!");
        //Debug.LogError("이 함수는 에러 문구를 표시!");
    }

    // 매 프레임마다 호출
    void Update()
    {
        //Vector3 position = transform.position;
        //position.z += 0.01f;

        //transform.position = position;
        //transform.Translate(0, 0, 0.01f);

        //if(Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(-0.01f, 0, 0);
        //}
        
        //if(Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(0.01f, 0, 0);
        //}   
        
        //if(Input.GetKey(KeyCode.W))
        //{
        //    transform.Translate(0, 0, 0.01f);
        //}   
        
        //if(Input.GetKey(KeyCode.S))
        //{
        //    transform.Translate(0, 0, -0.01f);
        //} 
        
        //if(Input.GetKey(KeyCode.Q))
        //{
        //    transform.Rotate(0, -1.0f, 0);
        //}
        
        //if(Input.GetKey(KeyCode.E))
        //{
        //    transform.Rotate(0, 1.0f, 0);
        //}

        Rigidbody body = GetComponent<Rigidbody>();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(0, 1000.0f, 0, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.W))
        {
            body.AddForce(0, 0, 10.0f, ForceMode.Impulse);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            body.AddForce(-10.0f, 0, 0, ForceMode.Impulse);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            body.AddForce(0, 0, -10.0f, ForceMode.Impulse);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            body.AddForce(10.0f, 0, 0, ForceMode.Impulse);
        }

    }
}
