using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public Text goalText;
    public GameObject Panel;
    void Start()
    {
        Panel.gameObject.SetActive(false);
        goalText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKey(KeyCode.UpArrow)){
        //    rb.AddForce(0, 0, 5);
        //}
        //if(Input.GetKey(KeyCode.DownArrow)){
        //    rb.AddForce(0, 0, -5);
        //}
        //if(Input.GetKey(KeyCode.LeftArrow)){
        //    rb.AddForce(-5, 0, 0);
        //}
        //if(Input.GetKey(KeyCode.RightArrow)){
        //    rb.AddForce(5, 0, 0);
        //}
        if(transform.position.y < -15){
            transform.position = new Vector3(0, 4, 0);
            rb.velocity = Vector3.zero;
        }
    }
    void OnCollisionStay(Collision hit)
    {
        if(hit.gameObject.tag == "Enemy"){
            transform.position = new Vector3(0, 4, 0);
        }
        if(hit.gameObject.tag == "Goal"){
            SceneManager.LoadScene("End");
            //goalText.gameObject.SetActive(true);
            //goalText.text = "GAME CLEAR!!";
            //Panel.gameObject.SetActive(true);
        }
        if(hit.gameObject.tag == "Ground")
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rb.AddForce(0, 0, 10);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                rb.AddForce(0, 0, -10);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(-10, 0, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(10, 0, 0);
            }
        }
    }

}
