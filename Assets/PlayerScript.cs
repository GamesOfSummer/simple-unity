using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 10.0F;

    void Update()
    {
      var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
      transform.position += move * speed * Time.deltaTime;   
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
	    Debug.Log("xxxxx");

        if (other.tag == "Dino")
        {
             transform.position = new Vector3(0,0,0);
        }    
    }

}
