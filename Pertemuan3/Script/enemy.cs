using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        if(player.transform.position.x > transform.position.x) {
            transform.position = new Vector3 (
                transform.position.x + 2 * Time.deltaTime,
                transform.position.y,
                transform.position.z);
        }
        else if(player.transform.position.x < transform.position.x) {
            transform.position = new Vector3 (
                transform.position.x - 2 * Time.deltaTime,
                transform.position.y,
                transform.position.z);
        }
        if(player.transform.position.y > transform.position.y) {
            transform.position = new Vector3 (
                transform.position.x,
                transform.position.y + 2 * Time.deltaTime,
                transform.position.z);
        }
        else if(player.transform.position.y < transform.position.y) {
            transform.position = new Vector3 (
                transform.position.x,
                transform.position.y - 2 * Time.deltaTime,
                transform.position.z);
        }
    }
}
