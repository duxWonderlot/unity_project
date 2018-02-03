using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast12 : MonoBehaviour {


    Ray ray;
     
    float raydistance = 25;
    private float timer =0;
    public int framecount = 0;
    public GameObject paintballprefab;
    public GameObject paintball;
    public GameObject obj11;
    public Vector3 position;
    public bool istrue = false;
    public bool spotted ,sp;
    // Stephen barrr reference
    // Use this for initialization
    public bs2 bsScript; 
    void Start () {

        

        bsScript = obj11.GetComponent<bs2>();

	}

    // Update is called once per frame

    void Update()
    {

        RaycastHit hit;


        spotted = false;



        framecount++;

        ray = new Ray(transform.position, -Vector3.right);

        

        
            if (Physics.Raycast(ray, out hit, raydistance) && hit.transform.tag == "1")
            {

                GameObject playerhit = hit.transform.gameObject;
                if (istrue == true)
                {
                    if (playerhit.GetComponent<playerInfo>())
                    {


                    if (paintball == null)
                    {

                        //paintball = Instantiate(paintballprefab, transform.position, transform.rotation) as GameObject;
                        //paintball.transform.position = transform.TransformPoint(Vector3.zero * 10.0f);
                        // paintball.transform.position = transform.TransformPoint(-2,0,0);
                        // paintball.transform.rotation = transform.rotation;
                        bsScript.istrue5q = true;

                    }

                }
                }
                timer += Time.fixedDeltaTime;



                Debug.Log("You hit a ray");
                Debug.DrawRay(transform.position, -Vector3.right * raydistance, Color.green);

                //Debug.DrawLine(transform.position , transform.position+Vector3.left *raydistance , Color.red );




                if (timer >= 5 && framecount > 0)
                {

                    Debug.Log("!(Suspicious)");
                    framecount = 0;
                    Debug.Log(framecount);
                    if (timer >= 10)
                    {

                        Debug.Log("Alert");
                        istrue = true;
                        return;

                    }
                    else if (istrue == true)
                    {


                        istrue = false;


                    }



                }





            }
            else
            {


                timer = 0;
                return;




            }

        

/*
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, raydistance))
        {
            print("There is something in front of the object!");
            Debug.DrawRay(transform.position , transform.position , Color.green);
             
        }

    */


    }









}
