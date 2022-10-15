using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectMovement : MonoBehaviour
{
    Vector3 kekanan;
    Vector3 kekiri;
    Vector3 keatas;
    Vector3 kebawah;
    Vector3 maju;
    Vector3 mundur;
    public float speed;
    public float speedRotasi;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)) {
            transform.position = new Vector3(
            transform.position.x - speed * Time.deltaTime,
            transform.position.y,
            transform.position.z);
        }
        if(Input.GetKey(KeyCode.W)) {
            transform.position = new Vector3(
            transform.position.x,
            transform.position.y + speed * Time.deltaTime,
            transform.position.z);
        }
        if(Input.GetKey(KeyCode.S)) {
            transform.position = new Vector3(
            transform.position.x,
            transform.position.y - speed * Time.deltaTime,
            transform.position.z);
        }
        if(Input.GetKey(KeyCode.D)) {
            transform.position = new Vector3(
            transform.position.x + speed * Time.deltaTime,
            transform.position.y,
            transform.position.z);
        }
    }
    
    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "enemyTag"){
            Debug.Log ("Game Over");
            Time.timeScale = 0;
        }
    }

    void OnCollisionStay2D(Collision2D coll) {
        if (coll.gameObject.tag == "coinTag"){
            coll.gameObject.SetActive(false);
            score += 1;
            Debug.Log ("Game Over" + score);
        }
    }
}