using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Raycast2 : MonoBehaviour {



    private int RaysToShoot = 20;
    private float timer = 0;
    //public int framecount = 0;
    public float angle = 0;
    Pthfinding pth;
    public GameObject obj;
    //public GameObject obj;
    private void Start()
    {

        //pth = obj.GetComponent<Pthfinding>();




    }

    void FixedUpdate()
    {


        //transform.LookAt(pth.path[pth.currentpoint]);  

        for (int i = 0; i < RaysToShoot; i++)
        {
            float x = Mathf.Sin(angle);
            float y = Mathf.Cos(angle);

            angle += 2 * Mathf.PI / RaysToShoot;



            Vector3 dir = new Vector3(transform.position.x + x, transform.position.y, transform.position.z + y);
            RaycastHit hit;
            Debug.DrawLine(transform.position, dir, Color.blue);
            if (Physics.Raycast(transform.position, dir, out hit )&& hit.transform.tag == "1")
            {
                // suspicous level


                timer += Time.fixedDeltaTime;

                Destroy(obj);
                SceneManager.LoadScene("porksng");
                Debug.Log("You hit a ray");


                // Debug.DrawLine(transform.position , transform.position+Vector3.left *raydistance , Color.red );






            }




        }
    }








}
