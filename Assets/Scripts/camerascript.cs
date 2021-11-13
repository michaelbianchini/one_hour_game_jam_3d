using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascript : MonoBehaviour
{
    public GameObject cam;
    public GameObject projectile;
    public float forwardForce;
    public float upForce;
    public GameObject shooter;
    Rigidbody rb;

    bool holding = false;




    private void Start()
    {
        rb = projectile.GetComponent<Rigidbody>();
    }

    void Update()
    {
        Camera mycam = cam.GetComponent<Camera>();

        float sensitivity = 0.05f;
        Vector3 vp = mycam.ScreenToViewportPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, mycam.nearClipPlane));
        vp.x -= 0.5f;
        vp.y -= 0.5f;
        vp.x *= sensitivity;
        vp.y *= sensitivity;
        vp.x += 0.5f;
        vp.y += 0.5f;
        Vector3 sp = mycam.ViewportToScreenPoint(vp);

        Vector3 v = mycam.ScreenToWorldPoint(sp);
        transform.LookAt(v, Vector3.up);


        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Ray ray = GetComponent<Camera>().ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            Vector3 destination = ray.GetPoint(10);
         
            // if (Physics.Raycast(transform.position, transform.forward, out hit))
            // {

            //            Instantiate(projectile,shooter.transform.position, shooter.transform.rotation);
            var projectileObj = Instantiate(projectile, shooter.transform.position, Quaternion.identity) as GameObject;
                projectileObj.GetComponent<Rigidbody>().velocity = (destination - shooter.transform.position).normalized * forwardForce;
                //projectile.transform.position = shooter.transform.position;
                //rb.AddForce(new Vector3(0, upForce, forwardForce), ForceMode.Force);
                //if (hit.transform.gameObject.name == "cursedbook")
                //{
                //    if (!holding)
                //    {
                //        hit.transform.SetParent(transform);
                //        holding = true;
                //    }
                //    else
                //    {
                //        hit.transform.SetParent(null);
                //        holding = false;
                //    }
                //}
            //}


        }
    }
}
