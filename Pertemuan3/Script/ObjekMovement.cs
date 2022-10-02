using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjekMovement : MonoBehaviour
{
   Vector3 kekanan;
    Vector3 kekiri;
    Vector3 keatas;
    Vector3 kebawah;
    Vector3 maju;
    Vector3 mundur;
    public float speed;
    public float speedRotasi;
    public int aksi;
    // Start is called before the first frame update
    void Start()
    {
        kekanan = new Vector3(1,0,0);
        kekiri = new Vector3(-1,0,0);
        keatas = new Vector3(0,1,0);
        kebawah = new Vector3(0,-1,0);
        maju = new Vector3(0,0,1);
        mundur = new Vector3(0,0,-1);
    }

    // Update is called once per frame
    void Update()
    {
        switch (aksi) {
        case 0:
            //translasi ke kanan
            transform.position = transform.position + (kekanan * speed * Time.deltaTime);
            break;
        case 1:
            //translasi ke kiri
            transform.position = transform.position + (kekiri * speed * Time.deltaTime);
            break;
        case 2:
            //translasi ke atas
            transform.position = transform.position + (keatas * speed * Time.deltaTime);
            break;
        case 3:
            //translasi ke bawah
            transform.position = transform.position + (kebawah * speed * Time.deltaTime);
            break;
        case 4:
            //rotasi ke kanan
            transform.rotation = transform.rotation *
            Quaternion.Euler(maju * speedRotasi * Time.deltaTime);
            break;
        case 5:
            //rotasi ke kiri
            transform.rotation = transform.rotation *
            Quaternion.Euler(mundur * speedRotasi * Time.deltaTime);
            break;
        }
    }
}
